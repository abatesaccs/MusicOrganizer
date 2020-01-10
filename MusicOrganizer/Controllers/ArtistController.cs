using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;


namespace MusicOrganizer.Controllers
{
    public class ArtistController : Controller
    {
        [HttpGet("/artist/create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("/artist/index")]
        public ActionResult Index(string artist)
        {
            Artist nextArtist = new Artist(artist);
            List <Artist> allArtists = Artist.GetAll();
            return View(allArtists);
        }
    }
}