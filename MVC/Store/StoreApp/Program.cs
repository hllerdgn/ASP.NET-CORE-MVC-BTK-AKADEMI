using Microsoft.EntityFrameworkCore;
using Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),b => b.MigrationsAssembly("StoreApp"));
});


builder.Services.AddDbContext<RepositoryContext>();

var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
