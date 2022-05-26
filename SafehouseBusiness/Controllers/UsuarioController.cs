using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using SafehouseBusiness.Models;
using System.Diagnostics;

namespace SafehouseBusiness.Controllers
{
    //[Autorizacao(NivelAcesso.Administrador, NivelAcesso.AdSafeHouse)]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILocalConsultaRepository _localConsultaRepository;
        private readonly IUsuarioLocalConsultaRepository _usuarioLocalConsultaRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository, ILocalConsultaRepository localConsultaRepository, IUsuarioLocalConsultaRepository usuariolocalConsultaRepository)
        {
            _localConsultaRepository = localConsultaRepository;
            _usuarioRepository = usuarioRepository;
            _usuarioLocalConsultaRepository = usuariolocalConsultaRepository;
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
                var retorno = _usuarioLocalConsultaRepository.BuscarUsuarioLocalConsulta(id);

                var model = new EditarUsuarioModel
                {
                    Usuario = retorno.First().Usuario,
                    UsuarioLocaisConsulta = retorno
                };

                return View(model);
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
                var usuarioRetorno = _usuarioRepository.Criar(request.Usuario);
                var localConsultaRetorno = _localConsultaRepository.Criar(request.LocalConsulta);


                var retorno = _usuarioLocalConsultaRepository.Criar(new UsuarioLocalConsulta
                {
                    Usuario = usuarioRetorno,
                    LocalConsulta = localConsultaRetorno
                });

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