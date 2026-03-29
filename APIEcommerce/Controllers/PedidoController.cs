using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APIEcommerce.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PedidoController : Controller
{
    private readonly ECommerceContext _context;
    private IPedidoRepository _pedidoRepository;

    public PedidoController(ECommerceContext context)
    {
        _context = context;
        _pedidoRepository = new PedidoRepository(_context);
    }

    [HttpGet]
    public IActionResult ListarTodos()
    {
        return Ok(_pedidoRepository.ListarTodos());
    }
}