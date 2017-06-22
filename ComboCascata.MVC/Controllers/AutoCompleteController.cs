using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComboCascata.MVC.Models;

namespace ComboCascata.MVC.Controllers
{
	public class AutoCompleteController : Controller
	{

		private List<PaisViewModel> _listapais = new List<PaisViewModel>()
		{
			new PaisViewModel() {idPais=1 , Nome="Brasil" },
			new PaisViewModel() {idPais=2 , Nome="Angola" }
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


		// GET: AutoComplete
		public ActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// Retorna lista de estados filtrado pelo parametro pasado na variável filtro.
		/// </summary>
		/// <param name="filtro">dados que deseja filtrar</param>
		/// <returns>Lista de estados</returns>
		public JsonResult ListaEstados(string filtro)
		{
			var ListComSelecione = new List<EstadoViewModel>();
			var ListComSelecioneComFiltro = new List<EstadoViewModel>();
			ListComSelecione.AddRange(_listaestados);
			ListComSelecione.Insert(0, new EstadoViewModel() { cod = -1, Nome = "Selecione..." });

			foreach (EstadoViewModel item in ListComSelecione)
			{
				if (item.Nome.ToLower().Contains(filtro.ToLower()))
				{
					ListComSelecioneComFiltro.Add(item);
				}
			}
			return Json(ListComSelecioneComFiltro, JsonRequestBehavior.AllowGet);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public JsonResult ListaEstadosAray()
		{
			var ListComSelecione = new List<EstadoViewModel>();
			ListComSelecione.AddRange(_listaestados);
			ListComSelecione.Insert(0, new EstadoViewModel() { cod = -1, Nome = "Selecione..." });
			return Json(ListComSelecione, JsonRequestBehavior.AllowGet);
		}

		public ActionResult testeParametros(string dado)
		{
			return View();
		}
	}
}