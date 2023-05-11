using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIKitTutorials.Entity
{
    internal class Purchase
    {
        public Purchase() { }
        public int Id { get; set; }
        public string Title { get; set; }
        public SqlDecimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int GameId { get; set; }
    }
}
