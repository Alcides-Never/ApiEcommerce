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
        throw new NotImplementedException();
    }

    public void Cadastrar(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
    }

    public void Atualizar(int id, Produto produto)
    {
        throw new NotImplementedException();
    }

    public void Deletar(int id)
    {
        throw new NotImplementedException();
    }
}