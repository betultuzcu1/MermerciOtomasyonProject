using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProject.EntityLayer.Concrete
{
    public class Voucher//fiş
    {
        public int VoucherId { get; set; }
        public string VoucherType { get; set;} //alış,satış,idae
        public DateTime VoucherDate { get; set; }
        public int CurrentCardId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public List<VoucherItem> VoucherItems { get; set; }
        public CurrentCard CurrentCard { get; set; }

    }
}
