using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Models;

namespace APIEcommerce.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    //Context Injection
    private readonly ECommerceContext _context;
    //CTOR
    public ProdutoRepository(ECommerceContext context)
    {
        _context = context;
    }

    public List<Produto> ListarTodos()
    {
        return _context.Produtos.ToList();
    }

    public Produto BuscarPorID(int id)
    {
        return _context.Produtos.FirstOrDefault(p => p.IdProduto == id);
    }

    public void Cadastrar(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
    }

    public void Atualizar(int id, Produto produto)
    {
        Produto produtoEncontrado = _context.Produtos.Find(id);
        if (produtoEncontrado == null)
        {
            throw new Exception();
        }

        produtoEncontrado.NomeProduto = produto.NomeProduto;
        produtoEncontrado.Descricao = produto.Descricao;
        produtoEncontrado.Preco = produto.Preco;
        produtoEncontrado.Categoria = produto.Categoria;
        produtoEncontrado.Imagem = produto.Imagem;
        produtoEncontrado.EstoqueDisponivel = produto.EstoqueDisponivel;

        _context.SaveChanges();
    }

    public void Deletar(int id)
    {
        Produto produtoEncontrado = _context.Produtos.Find(id);
        if (produtoEncontrado == null)
        {
            throw new Exception();
        }
        _context.Produtos.Remove(produtoEncontrado);
        _context.SaveChanges();
    }
}