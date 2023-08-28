using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProject.EntityLayer.Concrete
{
    public class Stock
    {
        public int StockId { get; set; }
        public string StockType { get; set;}
        public string StockCode { get; set;}
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
