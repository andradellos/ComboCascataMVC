using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComboCascata.MVC.Models;


namespace ComboCascata.MVC.Controllers
{
    public class AlbumController : Controller
    {
		// GET: Album

		public List<Genres> listaGeneros()
		{
			return new List<Genres>()
			{
				new Genres() {GenreId = 1, Name="album 1",Description= "Descrição A" },
				new Genres() {GenreId = 2, Name="album 2",Description= "Descrição B" },
				new Genres() {GenreId = 3, Name="album 3",Description= "Descrição C" },
				new Genres() {GenreId = 4, Name="album 4",Description= "Descrição D" },
				new Genres() {GenreId = 5, Name="album 5",Description= "Descrição F" }
			};
		}

		public List<Artist> listaArtista()
		{
			return new List<Artist>()
			{
				new Artist() {ArtistId = 1, Name="Artista 1" },
				new Artist() {ArtistId = 2, Name="Artista 2" },
				new Artist() {ArtistId = 3, Name="Artista 3" },
				new Artist() {ArtistId = 4, Name="Artista 4"},
				new Artist() {ArtistId = 5, Name="Artista 5"}
			};
		}

		public ActionResult Index()
        {
			SetGenreArtistViewBag();
			return View();
        }
		[HttpPost]
		public ActionResult Index(Albums album, int? GenreID = null, int? ArtistID = null)
		{
			SetGenreArtistViewBag(GenreID, ArtistID);
			return View();
		}

		private void SetGenreArtistViewBag(int? GenreID = null, int? ArtistID = null)
		{

			if (GenreID == null)

				ViewBag.GenreId = new SelectList(listaGeneros(), "GenreId", "Name");

			else

				ViewBag.GenreId = new SelectList(listaGeneros(), "GenreId", "Name", GenreID);

			if (ArtistID == null)

				ViewBag.ArtistId = new SelectList(listaArtista(), "ArtistId", "Name");

			else

				ViewBag.ArtistId = new SelectList(listaArtista(), "ArtistId", "Name", ArtistID);

		}
	}
}