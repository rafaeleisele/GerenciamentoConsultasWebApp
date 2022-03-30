using SafeHouseBusiness.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SafehouseBusiness.Controllers
{
    public class EnderecoController : Controller
    {
        // Não esquecer de aplicar a injeção de dependencia da Program.cs.
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoController(IEnderecoRepository enderecoRepository) => _enderecoRepository = enderecoRepository;

        // Criar a View Index na pasta Endereco.
        public ActionResult Index()
        {
            var enderecos = _enderecoRepository.BuscarEnderecosPorFiltro();
            return View(enderecos);
        }

        // Criar a View Details na pasta Endereco.
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
