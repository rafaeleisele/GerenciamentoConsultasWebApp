using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouseBusiness.Domain.Entidades
{
    public class UsuarioReuniao : Entity
    {
        public int IdUsuarioPaciente { get; set; }
        public int IdUsuarioConsultor { get; set; }
        public int IdReuniao { get; set; }

        public Reuniao Reuniao { get; set; }
        public Usuario UsuarioPaciente { get; set; }
        public Usuario UsuarioConsultor { get; set; }
    }
} 