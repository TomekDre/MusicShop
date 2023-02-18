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
                new VinylModel(){Id =1, Title="MVC", Artist="City Vortex", Description="Impactful Techno strikes", Category="Techno", Label="TMTO", Nr="TMTO1"},
                new VinylModel(){Id =2, Title="CVM", Artist="Ghostline", Description="Superbly grooving, effectively focused Techno fire", Category="Techno", Label="TMTO", Nr="TMTO2"},
                new VinylModel(){Id =3, Title="VMC", Artist="CVG", Description="Killer fiery big room Techno vigor", Category="Ambient", Label="TMTO", Nr="TMTO3"},
                new VinylModel(){Id =4, Title="136", Artist="City Vortex", Description="Ace forceful Techno", Category="Techno", Label="TMTO", Nr="TMTO4"},
                new VinylModel(){Id =5, Title="1235", Artist="Ghostline", Description="Ace, dark, textured Techno steppers",Category="House", Label="TMTO", Nr="TMTO5"},
                new VinylModel(){Id =6, Title="VMCCMMM", Artist="CVG", Description="Spacious, atmospheric, Detroitish House deepness", Category="Techno", Label="TMTO", Nr="TMTO6"},
            };
        }
    }
}
