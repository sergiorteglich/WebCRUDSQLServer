using Microsoft.EntityFrameworkCore;
using WebCRUDSQLServer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer
    ("Server=WINAPZE34PPEGMP;DataBase=Avanade;Trusted_Connection=True"));
             
// Acesso ao Autenticação do Windows no MySQL Server
// ("Server=DESKTOP-VEJJ82F\\SQLEXPRESS;DataBase=CRUD_MVC_SQL;Trusted_Connection=True"));

// Acesso ao BD do MicroSoft SQL Server
// ("Data Source=DESKTOP-VEJJ82F\SQLEXPRESS;Initial Catalog=CRUDMVCSQL;Integrated Security=False;User ID=Sergio;Password=12345;Connect T

// Acesso ao BD do MySQL e Workbench
// ("Server=localhost;initial catalog=CRUD_MVC_MYSQL_AULA;uid=root;pwd= ",Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql")));


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
