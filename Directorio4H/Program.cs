using Directorio4H.Components;
using Directorio4H.Data;
using Directorio4H.Repostorio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<BasedeDatosDbContext>(
    options =>
               options.UseSqlServer(
                     builder.Configuration.GetConnectionString(
                                              "DefaultConnection")));

builder.Services.AddScoped<IRepositorioPersonas, RepositorioPersonas>();
builder.Services.AddScoped<IRepositorioClasificaciones, RepositorioClasificaciones>();
builder.Services.AddScoped<IRepositorioHabitos, RepositorioHabitos>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
