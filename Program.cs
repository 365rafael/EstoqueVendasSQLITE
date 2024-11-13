using EstoqueVendasSQLITE.Configurations;
using EstoqueVendasSQLITE.Context;
using EstoqueVendasSQLITE.Services;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Carregar as configurações de e-mail do appsettings.json
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

// Configurar o NotificacaoService
builder.Services.AddTransient<NotificacaoService>();

// Configuração de cultura
var defaultDateCulture = "pt-BR";
var ci = new CultureInfo(defaultDateCulture);
ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
ci.DateTimeFormat.LongTimePattern = "HH:mm:ss";
CultureInfo.DefaultThreadCurrentCulture = ci;
CultureInfo.DefaultThreadCurrentUICulture = ci;

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"));
});

//builder.WebHost.ConfigureKestrel(options =>
//{
//    options.ListenLocalhost(5000);
//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Abrir o navegador automaticamente
//if (OperatingSystem.IsWindows())
//{
//    Process.Start(new ProcessStartInfo
//    {
//        FileName = "cmd",
//        Arguments = "/c start http://localhost:5000",
//        CreateNoWindow = true
//    });
//}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
