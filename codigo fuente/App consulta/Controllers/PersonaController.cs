using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_consulta.Data;
using App_consulta.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App_consulta.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ApplicationDbContext db;


       



        public PersonaController(ApplicationDbContext context)
        {
            db = context;
           
        }



        [Authorize(Policy = "Persona.Listado")]
        public IActionResult Listado() {



            return View();
        }



        [Authorize(Policy = "Persona.Listado")]
        public async Task<IActionResult> ListAjax()
        {
            List<PersonaModel> PersonasOriginal = await db.Persona.Include(n=>n.Actividad).Include(n => n.Playa).ToListAsync();

            var pagosTemp = db.Pago.ToList().GroupBy(n => n.IdPersona);
            var pagos = pagosTemp.ToDictionary(n => n.Key, n => n.Count());

           

            List<PersonaViewModel> Personas = PersonasOriginal.Select(n => new PersonaViewModel
            {
                Id = n.Id,
                Nombre = n.Nombre,
                Correo = n.Correo,
                Telefono = n.Telefono,
                Edad = n.Edad,
                Sexo = n.Sexo,
                Foto = n.Foto,
                Actividad = n.Actividad.Nombre,
                Playa = n.Playa.Nombre,
                Confianza = n.Confianza,
                Ambulante = n.Ambulante,
                Pagos = pagos.ContainsKey(n.Id) ? pagos[n.Id] : 0
            }).ToList();



            return Json(Personas);
        }


        [Authorize(Policy = "Persona.Detalle")]
        public async Task<IActionResult> Detalles(int Id)
        {

            var pagosmax = db.Configuracion.FirstOrDefault().pagos;
            var pagos = db.Pago.Where(n => n.IdPersona == Id).Count();

            var permisoResponsable = User.HasClaim(c => (c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Persona.Pagar" && c.Value == "1"));

            if (permisoResponsable == true)
            {
                if (pagos >= pagosmax)
                {
                    ViewBag.pagos = "false";
                }
                else
                {
                    ViewBag.pagos = "true";
                }
            }
            else { ViewBag.pagos = "hide"; }


            var persona = await db.Persona.Include(n=>n.Actividad).Include(n=>n.Playa).Where(n=>n.Id == Id).FirstOrDefaultAsync();
            
            return View(persona);
        }



        [Authorize(Policy = "Persona.Detalle")]
        public async Task<IActionResult> ListadoPagosAjax(int Id)
        {
            var pagos = await db.Pago.Where(n => n.IdPersona == Id).ToListAsync();


            return Json(pagos);
        }



        [Authorize(Policy = "Persona.Pagar")]
        [HttpPost]
        public async Task<IActionResult> Pagar(PAgoCreateModel pago)
        {
            string respuesta = "false";
            var persona = await db.Persona.Include(n=>n.Actividad).Where(n=>n.Id == pago.staticcedula).FirstOrDefaultAsync();

            if (persona != null) {
                if (pago.inputvalor > 1  && pago.inputadjunto_upload_cedula != null && pago.inputadjunto_upload_comprobante != null){


                    var pagosmax = db.Configuracion.FirstOrDefault().pagos;
                    var pagos = db.Pago.Where(n => n.IdPersona == pago.staticcedula).Count();
                    if(pagos >= pagosmax) { return Json("La persona ya recibió el máximo numero de pagos posibles"); }
                    try
                    {



                        PagoModel pagodb = new PagoModel
                        {
                            IdPersona = pago.staticcedula,
                            Valor = persona.Actividad.Valor,
                            Mes = (pagos+1).ToString(),
                            Estado = "Pagado",
                            Fecha = DateTime.Now,
                            IdUsuario = User.Identity.Name,
                            Nombreusuario = User.Identity.Name,
                            Soporte1 = pago.inputadjunto_upload_cedula,
                            Soporte2 = pago.inputadjunto_upload_comprobante
                        };

                        await db.AddAsync(pagodb);

                        await db.SaveChangesAsync();

                        respuesta = "true";
                    }
                    catch (Exception e)
                    {

                    }
                }
            }


            return Json(respuesta);
        }



        [Authorize(Policy = "Persona.Detalle")]
        public async Task<IActionResult> DetallesPago(int Id)
        {


            var Pago = await db.Pago.Where(n => n.Id == Id).Include(n => n.Persona).Include(n=>n.Persona.Actividad).Include(n => n.Persona.Playa).FirstOrDefaultAsync();

            return View(Pago);
        }


    }


}
