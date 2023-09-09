namespace OtomasyonProject.WebUI.Models.Voucher
{
    public class AddVoucherVM
    {
        public string VoucherType { get; set; } //alış,satış,idae
        public int CurrentCardId { get; set; }
        public DateTime VoucherDate { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
