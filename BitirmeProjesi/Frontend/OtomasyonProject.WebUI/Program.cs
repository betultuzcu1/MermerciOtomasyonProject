using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc.Authorization;
using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.DAL.Concrete;
using OtomasyonProject.DAL.EntityFramework;
using OtomasyonProject.EntityLayer.Concrete;
using AppUser = OtomasyonProject.EntityLayer.Concrete.AppUser;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient();
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IMarbleBlockDAL, EfMarbleBlockDal>();
builder.Services.AddScoped<IVoucherItemDAL, EfVoucherItemDal>();
builder.Services.AddScoped<IVoucherDAL, EfVoucherDal>();
builder.Services.AddScoped<IStockDAL, EfStockDal>();
builder.Services.AddScoped<IPlateDAL, EfPlateDal>();
builder.Services.AddScoped<ICurrentDAL, EfCurrentCartDal>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.LoginPath = new PathString("/Login/Index");
});

builder.Services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(Path.GetTempPath()));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
