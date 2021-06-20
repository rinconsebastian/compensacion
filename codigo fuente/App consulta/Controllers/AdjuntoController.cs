using App_consulta.Data;
using App_consulta.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace App_consulta.Controllers
{
    public class AdjuntoController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IWebHostEnvironment _env;
       

        public AdjuntoController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            db = context;
            _env = env;
           
        }

        [HttpPost]
        public async Task<IActionResult> Create(IFormFile file, string id, string time, string name = null)
        {
           AdjuntoModel adjunto = new AdjuntoModel
           {Loaded= false
           };

            if (file != null && file.Length > 0)
            {
                var idInt = Int32.Parse(id);
                

                    try
                    {
                        var _path = Path.Combine(_env.ContentRootPath, "wwwroot");
                        //Crea la carpeta
                        var _pathFolder = Path.Combine(_path, "Adjuntos", id);
                        if (!Directory.Exists(_pathFolder))
                        {
                            Directory.CreateDirectory(_pathFolder);
                        }
                        //Carga el archivo
                        var _fileName = id + "-" + time + "-" + Path.GetFileName(file.FileName);
                        var _pathFile = Path.Combine(_pathFolder, _fileName);
                        using (var fileStream = new FileStream(_pathFile, FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                        }
                    adjunto.Loaded = true;
                    adjunto.Nombre = _fileName;
                    adjunto.Ruta = _path;


                }
                    catch (Exception e) { adjunto.Nombre = "Error: " + e.Message; }

                
                

            }
            else { adjunto.Nombre = "Error: El archivo no es válido."; }
            return Json(adjunto);
        }

       
    }
}