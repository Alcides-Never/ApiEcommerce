using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Models;

namespace APIEcommerce.Repositories;

public class ItemPedidoRepository : IItemPedidoRepository
{
    private readonly ECommerceContext _context;

    public ItemPedidoRepository(ECommerceContext context)
    {
        _context = context;
    }
    
    public List<ItemPedido> ListarTodos()
    {
        return _context.ItemPedidos.ToList();
    }

    public ItemPedido BuscarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(ItemPedido itemPedido)
    {
        _context.ItemPedidos.Add(itemPedido);
    }

    public void Atualizar(int id, ItemPedido itemPedido)
    {
        throw new NotImplementedException();
    }

    public void Deletar(int id)
    {
        throw new NotImplementedException();
    }
}