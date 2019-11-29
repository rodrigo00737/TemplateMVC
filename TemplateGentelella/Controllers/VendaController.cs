using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateGentelella.Models;

namespace TemplateGentelella.Controllers
{
    public class VendaController : Controller
    {
        List<Venda> vendas = new List<Venda>()
        {
            { new Venda { Id = 1, Nome = "Sachin", DataVenda= DateTime.Now } },
            { new Venda { Id = 1, Nome = "venda 2", DataVenda= DateTime.Now } },
            { new Venda { Id = 1, Nome = "nova venda", DataVenda= DateTime.Now } }
        };

        // GET: Venda
        public ActionResult Index()
        {
            return View(vendas);
        }

        // GET: Venda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Venda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Venda/Create
        [HttpPost]
        public ActionResult Create(Venda collection)
        {
            try
            {

                var newVenda = new Venda() { Id = 5, Nome = collection.Nome, DataVenda = collection.DataVenda};

                vendas.Add(newVenda);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Venda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Venda/Edit/5
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

        // GET: Venda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Venda/Delete/5
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
