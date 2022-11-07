using Fogueo2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fogueo2.Controllers
{
    public class MateriasController1 : Controller
    {
        // GET: MateriasController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: MateriasController1/Details/5
        public ActionResult Details(int id)
        {
            //return View();
            var Materias = from a in RecuperaMaterias()
                           orderby a.idMateria
                           select a;
            return View(Materias);
        }

        // GET: MateriasController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MateriasController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MateriasController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MateriasController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MateriasController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MateriasController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [NonAction]
        public List<Materias> RecuperaMaterias()
        {
            return new List<Materias>
            {
                new Materias
                {
                    idMateria="ING-004", nombre_materia= "Inglés Nivel 10-12", creditos= 0,
                },

                new Materias
                {
                    idMateria="CBG-210", nombre_materia= "Probabilidad y Estadistica", creditos= 3,
                },

                 new Materias
                {
                    idMateria="FIS-110", nombre_materia= "Fisica General", creditos= 4,
                },

                 new Materias
                {
                    idMateria="FIS-110-L", nombre_materia= "Laboratorio Fisica General", creditos= 1,
                },

                   new Materias
                {
                    idMateria="MAT-102", nombre_materia= "Cálculo Integral", creditos= 5,
                },

                      new Materias
                {
                    idMateria="TDS-005", nombre_materia= "Diseño Centrado en el usuario", creditos= 4,
                },

                   new Materias
                {
                    idMateria="TDS-006", nombre_materia= "Programación II", creditos= 4,
                },

                  new Materias
                {
                    idMateria="TDS-008", nombre_materia= "Programación web", creditos= 4,
                }




            };
        }
    }
}
