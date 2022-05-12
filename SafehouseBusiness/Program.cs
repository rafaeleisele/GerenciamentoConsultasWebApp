using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Infra.Repository;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Infra.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("bdTeste"));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();
builder.Services.AddScoped<IDocumentoRepository, DocumentoRepository>();
builder.Services.AddScoped<ILocalConsultaRepository, LocalConsultaRepository>();
builder.Services.AddScoped<IUsuarioLocalConsultaRepository, UsuarioLocalConsultaRepository>();

var provider = builder.Services.BuildServiceProvider();

var repo = provider.GetService<IUsuarioRepository>();
var repoLocalConsulta = provider.GetService<ILocalConsultaRepository>();
var repoUsuarioLocalConsulta = provider.GetService<IUsuarioLocalConsultaRepository>();

var localConsulta = new LocalConsulta
{
    Nome = "Ed Nações Unidas",
    Endereco = new Endereco
    {
        Cep = "01311100",
        Cidade = "São Paulo",
        Logradouro = "Av Paulista",
        Bairro = "Bela Vista",
        Numero = "663"
    }
};
<<<<<<< Updated upstream
var usuario = new Usuario {
=======
var usuario = new Usuario
{
>>>>>>> Stashed changes
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

var retorno = repo.Criar(usuario);
var retornoLocal = repoLocalConsulta.Criar(localConsulta);

repoUsuarioLocalConsulta.Criar(new UsuarioLocalConsulta
{
    Usuario = retorno,
    LocalConsulta = retornoLocal
});

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



