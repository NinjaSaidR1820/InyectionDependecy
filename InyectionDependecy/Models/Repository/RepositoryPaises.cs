using InyectionDependecy.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InyectionDependecy.Models.Repository
{
    public class RepositoryPaises: RepositoryGeneric<WebApiPaisesEntities,Paises>,IRepositoryPaises
    {
    }
}