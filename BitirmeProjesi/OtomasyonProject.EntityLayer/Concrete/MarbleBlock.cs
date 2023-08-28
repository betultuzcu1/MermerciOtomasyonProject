using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProject.EntityLayer.Concrete
{
    public class MarbleBlock
    {
        public int MarbleBlockId { get; set; }
        public int StockId { get; set; }
        public float Width { get; set; }
        public float Height{ get; set; }
        public float Thickness{ get; set; }
        public DateTime PurchaseDate { get; set; }
        public string BlockCode { get; set; }
        public string WarehouseSection { get; set; }

    }
}
