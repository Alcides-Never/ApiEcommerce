using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Models;
using APIEcommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APIEcommerce.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PedidoController : ControllerBase
{
    private IPedidoRepository _pedidoRepository;

    public PedidoController(IPedidoRepository pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }

    [HttpGet]
    public IActionResult ListarTodos()
    {
        return Ok(_pedidoRepository.ListarTodos());
    }

    [HttpGet("{id}")]
    public IActionResult ListarPorID(int id)
    {
        Pedido pedido = _pedidoRepository.BuscarPorID(id);
        if (pedido == null)
        {
            return NotFound();
        }

        return Ok(pedido);
    }

    [HttpPost]
    public IActionResult CadastrarPedido(Pedido pedido)
    {
        _pedidoRepository.Cadastrar(pedido);
        return Created();
    }

    [HttpPut("{id}")]
    public IActionResult Editar(int id, Pedido pedido)
    {
        try
        {
            _pedidoRepository.Atualizar(id, pedido);
            return Ok(pedido);
        }
        catch (Exception e)
        {
            return NotFound(e);
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(int id)
        {
            try
            {
                _pedidoRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return NotFound("Produto não Encontrado");
            }
        }


}