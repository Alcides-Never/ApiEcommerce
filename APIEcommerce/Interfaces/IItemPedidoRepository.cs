using APIEcommerce.Models;

namespace APIEcommerce.Interfaces;

public interface IItemPedidoRepository
{
    List<ItemPedido> ListarTodos();
    
    ItemPedido BuscarPorId(int id);
    
    void Cadastrar(ItemPedido itemPedido);

    void Atualizar(int id, ItemPedido itemPedido);

    void Deletar(int id);
}