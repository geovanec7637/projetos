using Microsoft.EntityFrameworkCore;
using cadastrocli.context;
using cadastrocli.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<cadastrocli.context.principal>(options =>
{
    options.UseSqlServer(builder
        .Configuration
        .GetConnectionString("cadastrocli"));
    services.AddScoped<IClientRepositorio, ClientRepositorio>();
});
    // Adicione essa linha para registrar o repositório
    services.AddScoped<IClientRepositorio, ClientRepositorio>();

    // Outras configurações...

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

AppDBinitializer.Seed(app);


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
