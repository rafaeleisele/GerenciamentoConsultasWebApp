using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouseBusiness.Domain.Entidades
{
    public class UsuarioLocalConsulta : Entity
    {
        public Usuario Usuario { get; set; }
        public LocalConsulta LocalConsulta { get; set; }
        public int IdUsuario { get; set; }
        public int IdLocalConsulta { get; set; }

    }
}
