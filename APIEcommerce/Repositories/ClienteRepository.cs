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
        return _context.Clientes.FirstOrDefault(p => p.IdCliente == id);
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
        Cliente clienteEncontrado = _context.Clientes.Find(id);
        if (clienteEncontrado == null)
        {
            throw new Exception();
        }

        clienteEncontrado.NomeCompleto = cliente.NomeCompleto;
        clienteEncontrado.Email = cliente.Email;
        clienteEncontrado.Telefone = cliente.Telefone;
        clienteEncontrado.Endereco = cliente.Endereco;
        clienteEncontrado.DataCadastro = cliente.DataCadastro;

        _context.SaveChanges();
    }

    public void Deletar(int id)
    {
        throw new NotImplementedException();
    }
}