using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComboCascata.MVC.Models;

namespace ComboCascata.MVC.Controllers
{
	public class EstadoPaisController : Controller
	{

		private List<PaisViewModel> _listapais = new List<PaisViewModel>()
		{
			new PaisViewModel() {idPais=1 , Nome="Brasil" },
			new PaisViewModel() {idPais=2 , Nome="Angola" },
			new PaisViewModel() {idPais=3 , Nome="Portugal" },
			new PaisViewModel() {idPais=3 , Nome="França" }
		};


		// GET: EstadoPais
		public ActionResult Index()
		{
			EstadoViewModel Objeto = new EstadoViewModel();
			Objeto.listaPais = _listapais;

			ViewBag.ddlListaPais = new SelectList(_listapais, "idPais", "Nome");
			return View(Objeto);
		}

		[HttpPost]
		public ActionResult Index(EstadoViewModel Objeto, List<string> listaPais)
		{
			EstadoViewModel Objetos = new EstadoViewModel();
			Objetos.listaPais = _listapais;

			ViewBag.ddlListaPais = new SelectList(_listapais, "idPais", "Nome", listaPais[0]);
			return View(Objeto);
		}

	}
}
