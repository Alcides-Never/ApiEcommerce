using APIEcommerce.Models;

namespace APIEcommerce.Interfaces;

public interface IProdutoRepository
{
    // Read - Lista produtos Geral
    List<Produto> ListarTodos();

    // Localizador de produto somente com ID
    Produto BuscarPorID(int id);

    // Create
    void Cadastrar(Produto produto);


    // Update
    void Atualizar(int id, Produto produto);

    // Delete
    void Deletar(int id);

}