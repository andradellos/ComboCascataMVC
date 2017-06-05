using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComboCascata.MVC.Models;

namespace ComboCascata.MVC.Controllers
{
    public class TesteDropController : Controller
    {

		public EstadoViewModel MyProp2
		{
			get
			{
				return (EstadoViewModel)TempData["MyProp2"];
			}
			set
			{
				TempData["MyProp2"] = value;
			}
		}

		private List<PaisViewModel> _listapais = new List<PaisViewModel>()
		{
			new PaisViewModel() {id=1 , Nome="Brasil" },
			new PaisViewModel() {id=2 , Nome="Angola" }
		};

		private List<EstadoViewModel> _listaestados = new List<EstadoViewModel>()
		{
			new EstadoViewModel() {cod=1 , Nome="Bahia",idPais=1 },
			new EstadoViewModel() {cod=2 , Nome="Ceará",idPais=1  },
			new EstadoViewModel() {cod=3 , Nome="Brasilia",idPais=1  },
			new EstadoViewModel() {cod=4 , Nome="Rio Grande",idPais=1 },
			new EstadoViewModel() {cod=5 , Nome="Luanda",idPais=2 },
			new EstadoViewModel() {cod=6 , Nome="Maputo",idPais=2  }

		};



		// GET: TesteDrop

		public ActionResult Index()
		{
			// Inserir linha 0 na lista
			var ListComSelecione = new List<EstadoViewModel>();
			ListComSelecione.AddRange(_listaestados);
			ListComSelecione.Insert(0, new EstadoViewModel() { cod = -1, Nome = "Selecione..." });			

			EstadoViewModel EsClsEsrado = new EstadoViewModel();
			EsClsEsrado._listaestados = ListComSelecione;
			TempData["Funcionario"] = EsClsEsrado;

			return View(EsClsEsrado);
		}

		[HttpPost]
		public ActionResult Index(EstadoViewModel collection)
		{
			 
			var ListComSelecione = new List<EstadoViewModel>();
			ListComSelecione.AddRange(_listaestados);
			ListComSelecione.Insert(0, new EstadoViewModel() { cod = -1, Nome = "Selecione..." });

			collection._listaestados = ListComSelecione;
		    TempData["Funcionario"] = collection;

			return RedirectToAction("pum", collection);
			//return View("pum",collection);
		}


		 
		public ActionResult Pum(EstadoViewModel collection)
		{
			try
			{
				//TempData.Keep("Funcionario");
				//EstadoViewModel collection = TempData["Funcionario"] as EstadoViewModel;

				var ListComSelecione = new List<EstadoViewModel>();
				ListComSelecione.AddRange(_listaestados);
				ListComSelecione.Insert(0, new EstadoViewModel() { cod = -1, Nome = "Selecione..." });
				 
				collection._listaestados = ListComSelecione;

				return View(collection);
			}
			catch
			{
				return View();
			}
		}

		[HttpPost]
		public ActionResult Pum(EstadoViewModel collection, string cod)
		{
			try
			{
				
				var ListComSelecione = new List<EstadoViewModel>();
				ListComSelecione.AddRange(_listaestados);
				ListComSelecione.Insert(0, new EstadoViewModel() { cod = -1, Nome = "Selecione..." });

				collection._listaestados = ListComSelecione;

				return View(collection);
			}
			catch
			{
				return View();
			}
		}



		[HttpPost]
		public ActionResult PDois(EstadoViewModel collection)
		{
			try
			{
				// TODO: Add insert logic here

				return View(collection);
			}
			catch
			{
				return View();
			}
		}

		[HttpPost]
		public ActionResult PTes(EstadoViewModel collection)
		{
			try
			{
				// TODO: Add insert logic here

				return View(collection);
			}
			catch
			{
				return View();
			}
		}













		// GET: TesteDrop/Details/5
		public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TesteDrop/Create
        public ActionResult Create()
        {
            return View();
        }






        // POST: TesteDrop/Create
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

        // GET: TesteDrop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TesteDrop/Edit/5
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

        // GET: TesteDrop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TesteDrop/Delete/5
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
