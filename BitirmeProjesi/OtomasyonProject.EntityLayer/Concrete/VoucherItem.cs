using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProject.EntityLayer.Concrete
{
    public class VoucherItem
    {
        public int VoucherItemID { get; set; } 
        public int VoucherID { get; set; } 
        public int StockID { get; set; } 
        public int Quantity { get; set; } 
        public decimal UnitPrice { get; set; } 
        public decimal TotalPrice { get; set; } 
        
    }
}
