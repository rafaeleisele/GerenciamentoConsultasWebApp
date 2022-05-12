using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouseBusiness.Domain.Enum
{
    public enum NivelAcesso
    {
        SemAutorizacao = 0,
        AdSafeHouse = 1,
        Administrador = 2,
        Portaria = 3,
        Secretaria = 4
    }
}
