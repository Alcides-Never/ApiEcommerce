using APIEcommerce.Models;

namespace APIEcommerce.Interfaces;

public interface IPedidoRepository
{
    List<Pedido> ListarTodos();

    Pedido BuscarPorID(int id);

    void Cadastrar(Pedido pedido);

    void Atualizar(int id, Pedido pedido);

    void Deletar(int id);

}