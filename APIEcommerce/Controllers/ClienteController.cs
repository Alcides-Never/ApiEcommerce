using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Models;
using APIEcommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APIEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClienteController : Controller
    {
        private readonly ECommerceContext _context;
        private IClienteRepository _clienteRepository;

        public ClienteController(ECommerceContext context)
        {
            _context = context;
            _clienteRepository = new ClienteRepository(_context);
        }

        [HttpGet]
        public IActionResult ListarClientes()
        {
            return Ok(_clienteRepository.ListarTodos());
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            Cliente cliente = _clienteRepository.BuscarPorId(id);
            if (cliente == null)
            {
                return null;
            }

            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult CadastrarCliente(Cliente cliente)
        {
            _clienteRepository.Cadastrar(cliente);
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, Cliente cliente)
        {
            try
            {
                _clienteRepository.Atualizar(id, cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _clienteRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound("Produto não Encontrado");
            }
        }
    }


}
