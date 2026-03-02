using APIEcommerce.Interfaces;
using APIEcommerce.Models;

namespace APIEcommerce.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    public List<Produto> ListarTodos()
    {
        throw new NotImplementedException();
    }

    public Produto BuscarPorID(int id)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Produto produto)
    {
        throw new NotImplementedException();
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