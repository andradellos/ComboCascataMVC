using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComboCascata.MVC.Models
{
	public class Genres
	{
		public int GenreId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public int AlbumId { get; set; }
		public Albums album { get; set; }
	}
}