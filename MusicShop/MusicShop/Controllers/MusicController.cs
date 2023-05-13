using Microsoft.AspNetCore.Mvc;
using MusicShop.Models;
using MusicShop.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicShop.Controllers
{
    public class MusicController : Controller
    {
        private readonly VinylRepository _vinylRepository = null;
        public MusicController(VinylRepository vinylRepository)
        {
            _vinylRepository = vinylRepository;
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

        public ViewResult AddNewMusic(bool isSuccess = false, int vinylId = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.VinylId = vinylId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewMusic(VinylModel vinylModel)
        {
            int id = await _vinylRepository.AddNewVinyl(vinylModel);
            if (id > 0)
            {
                return RedirectToAction(nameof(AddNewMusic), new { isSuccess = true, vinylId = id });
            }
            return View();
        }

    }
}
 