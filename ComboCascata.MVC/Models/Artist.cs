using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComboCascata.MVC.Models
{
	public class Artist
	{
		public int ArtistId { get; set; }
		public string Name { get; set; }

		public int AlbumId { get; set; }
		public Albums album { get; set; }
	}
}