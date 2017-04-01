using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComboCascata.MVC.Models;


namespace ComboCascata.MVC.Controllers
{
    public class HomeController : Controller
    {
        private List<PaisViewModel> _listapais = new List<PaisViewModel>()
        {
            new PaisViewModel() {id=1 , Nome="Brasil" },
            new PaisViewModel() {id=2 , Nome="Angola" }
        };

        private List<EstadoViewModel> _listaestados = new List<EstadoViewModel>()
        {
            new EstadoViewModel() {id=1 , Nome="Bahia",idPais=1 },
            new EstadoViewModel() {id=1 , Nome="Ceará",idPais=1  },
            new EstadoViewModel() {id=1 , Nome="Brasilia",idPais=1  },
            new EstadoViewModel() {id=1 , Nome="Rio Grande",idPais=1 },
            new EstadoViewModel() {id=1 , Nome="Luanda",idPais=2 },
            new EstadoViewModel() {id=1 , Nome="Maputo",idPais=2  }

        };


        public ActionResult Index()
        {
            // Inserir linha 0 na lista
            var ListComSelecione = new List<PaisViewModel>();
            ListComSelecione.AddRange(_listapais);
            ListComSelecione.Insert(0, new PaisViewModel() { id = -1, Nome = "Selecione..." });
            return View(ListComSelecione);
        }

        [HttpPost]
        public ActionResult ObterEstados(int idPais)
        {
            return Json(_listaestados.FindAll(x => x.idPais == idPais));
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}