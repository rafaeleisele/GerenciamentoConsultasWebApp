
using SafeHouseBusiness.Infra.Repository;
using SafeHouseBusiness.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Infra.Data;
using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Enum;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("bdTeste"));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();
builder.Services.AddScoped<IDocumentoRepository, DocumentosRepository>();
builder.Services.AddScoped<ILocalConsultaRepository, LocalConsultaRepository>();

var provider = builder.Services.BuildServiceProvider();

var repo = provider.GetService<IUsuarioRepository>();

var usuario = new Usuario
{
    Nome = "Elizabeth",
    Contato = new Contato
    {
        Email = "email@email.com.br",
        Telefone = "11900000000"
    },
    Documento = new Documento
    {
        TipoDocumento = TipoDocumento.Rg,
        Identificacao = "84848484"
    },
    Endereco = new Endereco
    {
        Cep = "01311100",
        Cidade = "São Paulo",
        Logradouro = "Av Paulista",
        Bairro = "Bela Vista",
        Numero = "663"

    }
};

repo.Criar(usuario);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Contato}/{action=Index}/{id?}");



app.Run();



