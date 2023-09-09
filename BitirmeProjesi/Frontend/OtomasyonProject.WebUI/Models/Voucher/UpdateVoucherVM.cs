namespace OtomasyonProject.WebUI.Models.Voucher
{
    public class UpdateVoucherVM
    {
        public int VoucherId { get; set; }
        public string VoucherType { get; set; } //alış,satış,idae
        public DateTime VoucherDate { get; set; }
        public int CurrentCardId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
