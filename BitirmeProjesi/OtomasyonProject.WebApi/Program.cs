using OtomasyonProject.BLL.Abstract;
using OtomasyonProject.BLL.Concrete;
using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.DAL.Concrete;
using OtomasyonProject.DAL.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IMarbleBlockDAL,EfMarbleBlockDal>();
builder.Services.AddScoped<IMarbleBlockService,MarbleBlockManager>();

builder.Services.AddScoped<IVoucherItemDAL, EfVoucherItemDal>();
builder.Services.AddScoped<IVoucherItemService, VoucherItemManager>();

builder.Services.AddScoped<IVoucherDAL, EfVoucherDal>();
builder.Services.AddScoped<IVoucherService, VoucherManager>();

builder.Services.AddScoped<IStockDAL, EfStockDal>();
builder.Services.AddScoped<IStockService, StockManager>();

builder.Services.AddScoped<IPlateDAL, EfPlateDal>();
builder.Services.AddScoped<IPlateService, PlateManager>();

builder.Services.AddScoped<ICurrentDAL, EfCurrentCartDal>();
builder.Services.AddScoped<ICurrentCardService, CurrentCardManager>();



builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtomasyonApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("OtomasyonApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
