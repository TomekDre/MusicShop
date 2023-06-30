using Microsoft.EntityFrameworkCore;
using MusicShop.Data;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Repository
{
    public class VinylRepository
    {
        private readonly MusicShopContext _context = null;

        public VinylRepository(MusicShopContext context)
        {
            _context = context;
        }

        public async Task<int> AddNewVinyl(VinylModel model)
        {
            var newMusic = new Music()
            {
                Artist = model.Artist,
                CreatedOn = DateTime.UtcNow,
                Title = model.Title,
                Description = model.Description,
                Category = model.Category,
                Label = model.Label,
                Nr = model.Nr,
                UpdatedOn = DateTime.UtcNow
            };

            await _context.Music.AddAsync(newMusic);
            await _context.SaveChangesAsync();

            return newMusic.Id;
        }
        public async Task<List<VinylModel>> GetAllVinyls()
        {
            var vinyls = new List<VinylModel>();
            var allvinyls = await _context.Music.ToListAsync();

            if (allvinyls?.Any()==true)
            {
                foreach (var vinyl in allvinyls)
                {
                    vinyls.Add(new VinylModel()
                    {
                        Artist = vinyl.Artist,
                        Title = vinyl.Title,
                        Category = vinyl.Category,
                        Label = vinyl.Label,
                        Nr = vinyl.Nr,
                        Description = vinyl.Description
                    });
                }
            }
            return vinyls;
        }

        public async Task<VinylModel> GetVinyl(int id)
        {

            var vinyl = await _context.Music.FindAsync(id);
            
            if (vinyl != null)
            {
                var vinylDetails = new VinylModel()
                {
                    Artist = vinyl.Artist,
                    Title = vinyl.Title,
                    Category = vinyl.Category,
                    Label = vinyl.Label,
                    Nr = vinyl.Nr,
                    Description = vinyl.Description
                };

                return vinylDetails;
            }

            return null;

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
