using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SafeHouseBusiness.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouseBusiness.Domain.Attributes
{
    public class AutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        private readonly IList<NivelAcesso> _niveisAcesso;

        public AutorizacaoAttribute() { _niveisAcesso = new List<NivelAcesso>(); }
        public AutorizacaoAttribute(params NivelAcesso[] niveisAcesso) { _niveisAcesso = niveisAcesso; }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var teste = _niveisAcesso;

            context.Result = new RedirectResult ("/");
        }
    }
}
