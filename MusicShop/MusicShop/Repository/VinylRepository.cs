using MusicShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace MusicShop.Repository
{
    public class VinylRepository
    {
        public List<VinylModel> GetAllVinyls()
        {
            return DataSource();
        }
        public VinylModel GetVinyl(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
  
        }
        
        public List<VinylModel> SearchVinyl(string title, string artistName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Artist.Contains(artistName)).ToList();
        }

        private List<VinylModel> DataSource()
        {
            return new List<VinylModel>()
            {
                new VinylModel(){Id =1, Title="MVC", Artist="City Vortex"},
                new VinylModel(){Id =2, Title="CVM", Artist="Ghostline"},
                new VinylModel(){Id =3, Title="VMC", Artist="CVG"},
            };
        }
    }
}
