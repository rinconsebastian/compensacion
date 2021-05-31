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
                Pagos = (n.Pagos == null ? 0 : n.Pagos.Count)
            }).ToList();



            return Json(Personas);
        }


        [Authorize(Policy = "Persona.Listado")]
        public async Task<IActionResult> Detalles(int Id)
        {

            var persona = await db.Persona.Include(n=>n.Actividad).Include(n=>n.Playa).Where(n=>n.Id == Id).FirstOrDefaultAsync();
            
            return View(persona);
        }

    }


}
