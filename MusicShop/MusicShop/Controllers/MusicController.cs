using Microsoft.AspNetCore.Mvc;
using MusicShop.Models;
using MusicShop.Repository;
using System.Collections.Generic;

namespace MusicShop.Controllers
{
    public class MusicController : Controller
    {
        private readonly VinylRepository _vinylRepository = null;
        public MusicController()
        {
            _vinylRepository = new VinylRepository();
        }

        public ViewResult GetAllVinyls()
        {
            var data = _vinylRepository.GetAllVinyls();

            return View(data);
        }

        [Route("vinyl-details/{id}", Name = "vinylDetailsRoute")]
        public ViewResult GetVinyl(int id)
        {
            var data = _vinylRepository.GetVinyl(id);

            return View(data);
        }

        public List<VinylModel> SearchVinyl(string vinylTitle, string artistName)
        {
            return _vinylRepository.SearchVinyl(vinylTitle, artistName);
        }
    }
}
 