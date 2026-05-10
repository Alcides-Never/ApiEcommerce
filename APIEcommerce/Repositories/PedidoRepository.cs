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
        return _context.Pedidos.FirstOrDefault(p => p.IdPedido == id);
    }

    public void Cadastrar(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
        _context.SaveChanges();
    }

    public void Atualizar(int id, Pedido pedido)
    {
        Pedido pedidoEncontrado = _context.Pedidos.Find(id);
        if (pedidoEncontrado == null)
        {
            throw new Exception();
        }

        pedidoEncontrado.DataPedido = pedido.DataPedido;
        pedidoEncontrado.Status = pedido.Status;
        pedidoEncontrado.ValorTotal = pedido.ValorTotal;
        pedidoEncontrado.IdCliente = pedido.IdCliente;

    }

    public void Deletar(int id)
    {
        Pedido pedidoEncontrado = _context.Pedidos.Find(id);
        if (pedidoEncontrado == null)
        {
            throw new Exception();
        }

        _context.Pedidos.Remove(pedidoEncontrado);
        _context.SaveChanges();
    }
}