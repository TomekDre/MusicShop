using System;
using System.Collections.Generic;

namespace MusicShop.Models
{
    public class VinylModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        internal List<VinylModel> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
