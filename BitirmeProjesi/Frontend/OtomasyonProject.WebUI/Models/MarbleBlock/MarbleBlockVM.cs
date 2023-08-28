namespace OtomasyonProject.WebUI.Models.MarbleBlock
{
    public class MarbleBlockVM
    {
        public int MarbleBlockId { get; set; }
        public int StockId { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Thickness { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string BlockCode { get; set; }
        public string WarehouseSection { get; set; }
    }
}
