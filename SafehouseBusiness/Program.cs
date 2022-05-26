using SafeHouseBusiness.Infra.Repository;
using SafeHouseBusiness.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Infra.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var connetionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString), b => b.MigrationsAssembly("SafehouseBusiness"));
});

builder.Services.AddAuthentication("CookieAuthentication")
    .AddCookie("CookieAuthentication", config =>
    {
        config.Cookie.Name = "SafehouseBusinessLogin";
        config.LoginPath = "/Login/UserLogin";
    });

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();
builder.Services.AddScoped<IDocumentoRepository, DocumentoRepository>();
builder.Services.AddScoped<ILocalConsultaRepository, LocalConsultaRepository>();
builder.Services.AddScoped<IUsuarioLocalConsultaRepository, UsuarioLocalConsultaRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Contato}/{action=Index}/{id?}");



app.Run();



