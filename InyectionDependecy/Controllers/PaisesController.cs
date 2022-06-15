using InyectionDependecy.Contratos;
using InyectionDependecy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InyeccionDependencias.Controllers
{
    public class PaisesController : ApiController
    {
        private readonly IRepositoryPaises repositorioPaises;

        public PaisesController(IRepositoryPaises repositorioPaises)
        {
            this.repositorioPaises = repositorioPaises;
        }

        // GET: api/Paises
        public IEnumerable<Paises> Get()
        {
            return repositorioPaises.GetAll();
        }

        // GET: api/Paises/5
        public Paises Get(int id)
        {
            return repositorioPaises.Getfor(p => p.Id == id).First();
        }

        // POST: api/Paises
        public void Post([FromBody] Paises pais)
        {
            repositorioPaises.Create(pais);
        }

        // PUT: api/Paises/5
        public void Put(int id, [FromBody] Paises pais)
        {
            repositorioPaises.Update(pais);
        }

        // DELETE: api/Paises/5
        public void Delete(int id)
        {

        }
    }
}