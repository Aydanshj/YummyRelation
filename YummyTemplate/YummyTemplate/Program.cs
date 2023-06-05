using Microsoft.EntityFrameworkCore;
using YummyTemplate.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RelationDbContext>(opt =>

opt.UseSqlServer("Server=DESKTOP-PV206RC\\SQLEXPRESS; Database=YummyRelation; Integrated Security = true")

);


var app = builder.Build();

app.MapControllerRoute(

    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}"

    );

app.UseStaticFiles();

app.Run();
