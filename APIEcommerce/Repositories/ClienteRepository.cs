using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Models;

namespace APIEcommerce.Repositories;

public class ClienteRepository : IClienteRepository
{
    //Injection
    private readonly ECommerceContext _context;

    //CTOR
    public ClienteRepository(ECommerceContext context)
    {
        _context = context;
    }
    public List<Cliente> ListarTodos()
    {
        return _context.Clientes.ToList();
    }

    public Cliente BuscarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Cliente BuscarPorEmaileSenha(string email, string senha)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
    }

    public void Atualizar(int id, Cliente cliente)
    {
        throw new NotImplementedException();
    }

    public void Deletar(int id)
    {
        throw new NotImplementedException();
    }
}