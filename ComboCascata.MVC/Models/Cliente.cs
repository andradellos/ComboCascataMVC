using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComboCascata.MVC.Models
{
	public class Cliente
	{
		public int ClienteId { get; set; }
		public string Nome { get; set; }

		public List<Cliente> ListaClientes()
		{
			return new List<Cliente>
			{
				new Cliente { ClienteId = 1, Nome = "Eduardo Pires"},
				new Cliente { ClienteId = 2, Nome = "João Silva"},
				new Cliente { ClienteId = 3, Nome = "Fulano de Tal"}
			};
		}
	}
}