using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Models;
using APIEcommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APIEcommerce.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ItemPedidoController : ControllerBase
{
    // Um adendo, a primeira chamada foi sem criar o builder no program, não localizava. ao refazer a variável, ele
    //chamou o conteúdo declarado no program main
    private IItemPedidoRepository _itemPedidoRepository;

    public ItemPedidoController(IItemPedidoRepository batata)
    {
        _itemPedidoRepository = batata;
    }

    [HttpGet]
    public IActionResult ListarTodos()
    {
        return Ok(_itemPedidoRepository.ListarTodos());
    }

    [HttpPost]
    public IActionResult CadastrarItemPedido(ItemPedido itemPedido)
    {
        _itemPedidoRepository.Cadastrar(itemPedido);
        return Created();
    }

}