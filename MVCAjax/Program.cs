using MVCAjax.Data;
using MVCAjax.Repositories;

var builder = WebApplication.CreateBuilder(args);

// ilgili repository sýnýfýn hangi altyapýdan çalýþacaðýný burada sisteme tanýtýyoruz.
builder.Services.AddScoped<IProductRepository, ProductPostgreSqlRepository>();
builder.Services.AddDbContext<MySqlDbContext>();
builder.Services.AddDbContext<MsSqlDbContext>();
builder.Services.AddDbContext<PostgreSqlDbContext>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Home/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
