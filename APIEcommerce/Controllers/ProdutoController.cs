using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Models;
using APIEcommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APIEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ECommerceContext _context;
        private IProdutoRepository _produtoRepository;

        public ProdutoController(ECommerceContext context)
        {
            _context = context;
            _produtoRepository = new ProdutoRepository(_context);
        }

        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        [HttpPost]
        public IActionResult CadastrarProduto(Produto produto)
        {
            _produtoRepository.Cadastrar(produto);
            _context.SaveChanges();
            return Created();
        }
    }
}