using APIEcommerce.Models;

namespace APIEcommerce.Interfaces;

public interface IClienteRepository
{
    List<Cliente> ListarTodos();

    Cliente BuscarPorId(int id);

    Cliente BuscarPorEmaileSenha(string email, string senha);

    void Cadastrar(Cliente cliente);

    void Atualizar(int id, Cliente cliente);

    void Deletar(int id);
}