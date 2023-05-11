using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UIKitTutorials.Entity
{
    internal class Game
    {
        public Game() { }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string PublisherCountry { get; set; }
        public string PublisherWebsite { get; set; }
        public string PusblisherName { get; set; }
        public string Genre { get; set; }
        public decimal Rating { get; set; }
    }
}
