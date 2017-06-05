using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComboCascata.MVC.Models;

namespace ComboCascata.MVC.Controllers
{
	public class TesteDataBinderController : Controller
	{
		// GET: TesteDataBinder
		public ActionResult Index(int? IdDataBinder)
		{
			TesteDataBinder DadosDaTela = new TesteDataBinder();
			if (IdDataBinder.HasValue) { DadosDaTela.IdDataBinder = IdDataBinder.Value; }

			// Criando uma ViewBag com uma lista de clientes.
			// Utilizo o nome da ViewBag com ClienteId apenas
			// para facilitar o entendimento do código
			// new SelectList significa retornar uma
			// estrutura de DropDownList
			ViewBag.ClienteId = new SelectList
				(
					new Cliente().ListaClientes(),
					"ClienteId",
					"Nome"
				);

			return View();
		}
		[HttpPost]
		public ActionResult Index(TesteDataBinder DadosDaTela, string clienteId)
		{

			// O quarto parametro "clienteId" diz qual é o ID
			// que deve vir pré-selecionado ao montar o DropDownList
			ViewBag.ClienteId = new SelectList
				(
					new Cliente().ListaClientes(),
					"ClienteId",
					"Nome"
					,clienteId
				);

			return View("cadastro", DadosDaTela);
		}
		public ActionResult cadastro()
		{
			return View();
		}
		public ActionResult cadastro(TesteDataBinder DadosDaTela)
		{
			return View(DadosDaTela);
		}
	}
}
