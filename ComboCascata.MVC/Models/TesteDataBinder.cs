using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComboCascata.MVC.Models
{
	public class TesteDataBinder
	{
		public int IdDataBinder { get; set; }
		public string Nome { get; set; }
		public DateTime Data { get; set; }
		public decimal valor { get; set; }
		public string clienteId { get; set; }
	}
}