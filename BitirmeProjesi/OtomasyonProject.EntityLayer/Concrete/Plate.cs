using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProject.EntityLayer.Concrete
{
    public class Plate
    {
        public int PlateId { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Thickness { get; set; }
        public string WarehouseSection { get; set; }
        public string PlateCode { get; set; }
        public int MarbleBlockId { get; set; }
    }
}
