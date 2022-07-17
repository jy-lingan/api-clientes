using Microsoft.AspNetCore.Mvc;
using System.Linq;
using api_db.Models;

namespace api_db.Controllers
{
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        private Conexion dbConexion;
        public ClientesController(){
            dbConexion = Conectar.ConectarBaseDatos();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbConexion.Clientes.ToArray());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cliente = dbConexion.Clientes.FirstOrDefault(x => x.id_cliente == id);
            if (cliente == null)
                return NotFound();
            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Clientes cliente)
        {
            if (cliente == null)
                return BadRequest();
            dbConexion.Clientes.Add(cliente);
            dbConexion.SaveChanges();
            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Clientes cliente)
        {
            if (cliente == null)
                return BadRequest();
            var clienteActual = dbConexion.Clientes.FirstOrDefault(x => x.id_cliente == id);
            if (clienteActual == null)
                return NotFound();
            clienteActual.nombre = cliente.nombre;
            clienteActual.apellido = cliente.apellido;
            clienteActual.direccion = cliente.direccion;
            clienteActual.telefono = cliente.telefono;
            dbConexion.SaveChanges();
            return Ok(clienteActual);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = dbConexion.Clientes.FirstOrDefault(x => x.id_cliente == id);
            if (cliente == null)
                return NotFound();
            dbConexion.Clientes.Remove(cliente);
            dbConexion.SaveChanges();
            return Ok(cliente);
        }
    }
}