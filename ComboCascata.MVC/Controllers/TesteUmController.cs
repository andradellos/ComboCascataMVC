using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComboCascata.MVC.Controllers
{
    public class TesteUmController : Controller
    {
        // GET: TesteUm
        public ActionResult Index()
        {
            return View();
        }

        // GET: TesteUm/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TesteUm/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TesteUm/Create
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

        // GET: TesteUm/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TesteUm/Edit/5
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

        // GET: TesteUm/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TesteUm/Delete/5
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
