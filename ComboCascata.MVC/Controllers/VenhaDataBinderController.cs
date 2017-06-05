using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComboCascata.MVC.Models;

namespace ComboCascata.MVC.Controllers
{
    public class VenhaDataBinderController : Controller
    {
		// GET: VenhaDataBinder
		public ActionResult Index(int? IdDataBinder)
		{
			TesteDataBinder DadosDaTela = new TesteDataBinder();
			if (IdDataBinder.HasValue) { DadosDaTela.IdDataBinder = IdDataBinder.Value; }
			return View(DadosDaTela);
		}

		[HttpPost]
		public ActionResult Index(TesteDataBinder DadosDaTela)
		{
			return View(DadosDaTela);
		}


	}
}
