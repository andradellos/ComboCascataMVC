using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComboCascata.MVC.Models
{
	public class Albums
	{
		public int AlbumId { get; set; }
		public int GenreId { get; set; }
		public int ArtistId { get; set; }
		public string Title { get; set; }
		public decimal Price { get; set; }
		public string AlbumArtrl { get; set; }
		public List<Genres> Genero { get; set; }
		public List<Artist> Artista { get; set; }
	}
}