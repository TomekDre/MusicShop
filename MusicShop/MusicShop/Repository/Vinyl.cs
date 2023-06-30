using System;

namespace MusicShop.Repository
{
    internal class Vinyl
    {
        public Vinyl()
        {
        }

        public string Artist { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Label { get; set; }
        public string Nr { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}