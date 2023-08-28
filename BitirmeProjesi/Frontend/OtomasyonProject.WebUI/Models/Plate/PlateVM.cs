namespace OtomasyonProject.WebUI.Models.Plate
{
    public class PlateVM
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
