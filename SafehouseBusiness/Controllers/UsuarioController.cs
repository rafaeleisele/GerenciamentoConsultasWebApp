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
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILocalConsultaRepository _localConsultaRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository, ILocalConsultaRepository localConsultaRepository)
        {
            _localConsultaRepository = localConsultaRepository;
            _usuarioRepository = usuarioRepository;
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
        
        public IActionResult Editar(int id)
        {
            try
            {               
                return View(new EditarUsuarioModel(_usuarioRepository.ObterPorId(id)));
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
                var retorno = _usuarioRepository.Criar(request.Usuario);
                _localConsultaRepository.Criar(request.LocalConsulta);

                return RedirectToAction("Index");
            }
            catch
            {
                throw;
            }
        }

        public IActionResult Delete(int id)
        {
            _usuarioRepository.Deletar(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}