using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateGentelella.Models;

namespace TemplateGentelella.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {
            var pacientes = new List<Paciente>
            {
                new Paciente{Id=1,Nome="Carson",Telefone="62985451565", Endereco="Av. Antonio Perilo n° 546", Email="carson@gmail.com", DataNascimento=DateTime.Parse("2005-09-01")},
                new Paciente{Id=2,Nome="Meredith",Telefone="62985451565", Endereco="Av. Antonio Perilo n° 546", Email="carson@gmail.com",DataNascimento=DateTime.Parse("2002-09-01")},
                new Paciente{Id=3,Nome="Arturo",Telefone="62985451565", Endereco="Av. Antonio Perilo n° 546",Email="carson@gmail.com",DataNascimento=DateTime.Parse("2003-09-01")},
                new Paciente{Id=4,Nome="Gytis",Telefone="62985451565", Endereco="Av. Antonio Perilo n° 546",Email="carson@gmail.com",DataNascimento=DateTime.Parse("2002-09-01")},
                new Paciente{Id=5,Nome="Yan",Telefone="62985451565", Endereco="Av. Antonio Perilo n° 546",Email="carson@gmail.com",DataNascimento=DateTime.Parse("2002-09-01")},
                new Paciente{Id=6,Nome="Peggy",Telefone="62985451565", Endereco="Av. Antonio Perilo n° 546",Email="carson@gmail.com",DataNascimento=DateTime.Parse("2001-09-01")},
                new Paciente{Id=7,Nome="Laura",Telefone="62985451565", Endereco="Av. Antonio Perilo n° 546",Email="carson@gmail.com",DataNascimento=DateTime.Parse("2003-09-01")},
                new Paciente{Id=8,Nome="Nino",Telefone="62985451565", Endereco="Av. Antonio Perilo n° 546",Email="carson@gmail.com",DataNascimento=DateTime.Parse("2005-09-01")}
            };


            return View(pacientes);
        }

        // GET: Paciente/Details/5
        public ActionResult Details(int id)
        {
            var paciente = new Paciente
            {
                Id = 7,
                Nome = "Laura",
                Telefone = "62985451565",
                Endereco = "Av. Antonio Perilo n° 546",
                Email = "carson@gmail.com",
                DataNascimento = DateTime.Parse("2003-09-01")
            };

            return View(paciente);
        }

        // GET: Paciente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paciente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Paciente/Edit/5
        public ActionResult Edit(int id)
        {
            var paciente = new Paciente
            {
                Id = 7,
                Nome = "Laura",
                Telefone = "62985451565",
                Endereco = "Av. Antonio Perilo n° 546",
                Email = "carson@gmail.com",
                DataNascimento = DateTime.Parse("2003-09-01")
            };

            return View(paciente);
        }

        // POST: Paciente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Paciente/Delete/5
        public ActionResult Delete(int id)
        {
            var paciente = new Paciente
            {
                Id = 7,
                Nome = "Laura",
                Telefone = "62985451565",
                Endereco = "Av. Antonio Perilo n° 546",
                Email = "carson@gmail.com",
                DataNascimento = DateTime.Parse("2003-09-01")
            };
            return View(paciente);
        }

        // POST: Paciente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
