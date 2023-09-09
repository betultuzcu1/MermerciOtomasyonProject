using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProject.EntityLayer.Concrete
{
    public class CurrentCard //carikart
    {
        public int CurrentCardId { get; set; }
        public string CurrentTitle { get; set; }
        public string CurrentOwner{ get; set; } //yetkili kişi
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Mail{ get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public List<Voucher> Vouchers { get; set; }

    }
}
