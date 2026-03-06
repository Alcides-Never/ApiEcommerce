using APIEcommerce.Context;
using APIEcommerce.Interfaces;
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
    }


}
