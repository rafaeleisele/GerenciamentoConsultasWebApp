using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Repository;
using Microsoft.AspNetCore.Mvc;
using SafehouseBusiness.Models;
using System.Diagnostics;

namespace SafehouseBusiness.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILocalConsultaRepository _localConsultaRepository;
        //asas
        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioRepository usuarioRepository, ILocalConsultaRepository localConsultaRepository)
        {
            _localConsultaRepository = localConsultaRepository;
            _usuarioRepository = usuarioRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Usuario> usuarios = _usuarioRepository.BuscarUsuarioPorFiltro();

            return View(usuarios);
        }

        
        public IActionResult Criar()
        {
            try
            {
                return View();
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult Criar(CriarUsuarioModel request)
        {
            try
            {
                _usuarioRepository.Criar(request.Usuario);
                _localConsultaRepository.Criar(request.LocalConsulta);

                return RedirectToAction("Index");
            }
            catch
            {
                throw;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}