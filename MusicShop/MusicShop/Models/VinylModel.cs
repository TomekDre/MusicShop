using System;
using System.Collections.Generic;

namespace MusicShop.Models
{
    public class VinylModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Description { get; set; }
        public string Category { get; set; }
        public string Label { get; set; }
        public string Nr { get; set; }


        internal List<VinylModel> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
