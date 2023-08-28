
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OtomasyonProject.EntityLayer.Concrete;


namespace HotelProject.DAL.Concrete
{

    public class Context:IdentityDbContext<AppUser ,AppRole ,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HQIEVQ0\\SQLEXPRESS;Database=OtomasyonDb;uid=sa;pwd=123;Integrated Security=true");
        }
        public DbSet<MarbleBlock> MarbleBlocks { get; set; }
        public DbSet<Plate> Plates { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<CurrentCard> CurrentCards { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<VoucherItem> VoucherItems { get; set; }
        
    }
}
