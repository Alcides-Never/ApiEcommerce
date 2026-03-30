using APIEcommerce.Models;

namespace APIEcommerce.Interfaces;

public interface IPagamentoRepository
{
    List<Pagamento> ListarTodos();
    
    Pagamento BuscarPorId(int id);
    
    void Cadastrar (Pagamento pagamento);
    
    void Atualizar(int id, Pagamento pagamento);
    
    void Deletar(int id);
    
}