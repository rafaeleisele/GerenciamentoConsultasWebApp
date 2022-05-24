using Microsoft.AspNetCore.Mvc;
using SafeHouseBusiness.Domain.Interface;

namespace SafehouseBusiness.Controllers
{
    public class ContatoController : Controller
    {
        //Porque precisamos implementar isso?
        private readonly IContatoRepository _contatoRepository;
        //Criei o repository ContatoRepository

        //Para que serva a linha 13? É um construtor?
        public ContatoController(IContatoRepository contatoRepository) => _contatoRepository = contatoRepository;


        public IActionResult Index()
        {
            var contatos = _contatoRepository.BuscarContatosPorFiltro();
            return View(contatos);
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
