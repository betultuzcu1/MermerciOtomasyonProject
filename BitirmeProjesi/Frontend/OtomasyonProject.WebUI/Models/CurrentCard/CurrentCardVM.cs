namespace OtomasyonProject.WebUI.Models.CurrentCard
{
    public class CurrentCardVM
    {
        public int CurrentCardId { get; set; }
        public string CurrentTitle { get; set; }
        public string CurrentOwner { get; set; } //yetkili kişi
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Mail { get; set; }
        public bool IsActive { get; set; }
        
    }
}
