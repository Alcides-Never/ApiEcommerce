using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Models;

namespace APIEcommerce.Repositories;

public class PedidoRepository : IPedidoRepository
{

    private readonly ECommerceContext _context;

    public PedidoRepository(ECommerceContext context)
    {
        _context = context;
    }
    public List<Pedido> ListarTodos()
    {
        return _context.Pedidos.ToList();
    }

    public Pedido BuscarPorID(int id)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
    }

    public void Atualizar(int id, Pedido pedido)
    {
        throw new NotImplementedException();
    }

    public void Deletar(int id)
    {
        throw new NotImplementedException();
    }
}