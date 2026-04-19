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

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorID(int id)
        {
            Produto produto = _produtoRepository.BuscarPorID(id);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult CadastrarProduto(Produto produto)
        {
            _produtoRepository.Cadastrar(produto);
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, Produto produto)
        {
            try
            {
                _produtoRepository.Atualizar(id, produto);
                return Ok(produto);
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
                _produtoRepository.Deletar(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return NotFound("Produto não Encontrado");
            }
        }
    }
}