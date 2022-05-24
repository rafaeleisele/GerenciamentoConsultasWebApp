using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouseBusiness.Domain.Entidades
{
    public class UsuarioUnidade : Entity
    {
        public Unidade Unidade { get; set; }
        public Usuario Usuario { get; set; }
        public int IdUsuario { get; set; }
        public int IdUnidade { get; set; }
    }
}
