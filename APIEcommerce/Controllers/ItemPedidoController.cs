using APIEcommerce.Context;
using APIEcommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APIEcommerce.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ItemPedidoController : ControllerBase
{
    private readonly ECommerceContext _context;
    private ItemPedidoRepository _itemPedidoRepository;

    public ItemPedidoController(ECommerceContext context)
    {
        _context = context;
        _itemPedidoRepository = new ItemPedidoRepository(_context);
    }

    [HttpGet]
    public IActionResult ListarTodos()
    {
        return Ok(_itemPedidoRepository.ListarTodos());
    }

}