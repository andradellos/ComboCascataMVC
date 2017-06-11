using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComboCascata.MVC.Models
{
	public class Cliente
	{
		public int ClienteId { get; set; }
		public string NomeCliente { get; set; }

		public List<Cliente> ListaClientes()
		{
			return new List<Cliente>
			{
				new Cliente { ClienteId = 1, NomeCliente = "Eduardo Pires"},
				new Cliente { ClienteId = 2, NomeCliente = "João Silva"},
				new Cliente { ClienteId = 3, NomeCliente = "Fulano de Tal"}
			};
		}
	}
}