using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APIEcommerce.Controllers;

[Route("api/[controller]")]
[ApiController]

public class PagamentoController : ControllerBase
{
    private readonly ECommerceContext _context;
    private IPagamentoRepository _pagamentoRepository;

    public PagamentoController(ECommerceContext context)
    {
        _context = context;
        _pagamentoRepository = new PagamentoRepository(_context);
    }

    [HttpGet]
    public IActionResult ListarTodos()
    {
        return Ok(_pagamentoRepository.ListarTodos());
    }

}