using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComboCascata.MVC.Models
{

	public class EstadoViewModel
    {
        public int cod { get; set; }
        public string Nome { get; set; }
        public int idPais { get; set; }
		public List<EstadoViewModel> _listaestados { get; set; }
		 
	}
}