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
            return View();
        }

        public VinylModel GetVinyl(int id)
        {
            return _vinylRepository.GetVinyl(id);
        }

        public List<VinylModel> SearchVinyl(string vinylTitle, string artistName)
        {
            return _vinylRepository.SearchVinyl(vinylTitle, artistName);
        }
    }
}
