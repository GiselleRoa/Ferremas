using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Ferremas.API.Models;
using System.Threading.Tasks;

namespace Ferremas.API.Controllers
{
    public class ProductoController : ControllerBase
    {
        private static IList<Producto> lista = new List<Producto>();

        //GET
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            return lista;
        }
        //GET CON ID
        [HttpGet("{id}")]
        public Producto get(int id)
        {
            return lista.FirstOrDefault(x => x.id == id);
        }
        //POST 
        [HttpPost]
        public void post([FromBody] Producto value)
        {
            lista.Add(value);
        }
        // PUT CON ID
        [HttpPut("{id")]
        public void Put(int id, [FromBody] Producto value)
        {
            Producto selection = lista.FirstOrDefault(x => x.id == id);
            lista[lista.IndexOf(selection)] = value;
        }

        //DELETE CON ID

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            lista.Remove(lista.FirstOrDefault(x => x.id == id));
        }

    }
}
