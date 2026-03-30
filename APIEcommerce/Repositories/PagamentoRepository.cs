using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Models;

namespace APIEcommerce.Repositories;

public class PagamentoRepository : IPagamentoRepository
{
    private readonly ECommerceContext _context;

    public PagamentoRepository(ECommerceContext context)
    {
        _context = context;
    }
    
    
    public List<Pagamento> ListarTodos()
    {
        return _context.Pagamentos.ToList();
    }

    public Pagamento BuscarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Pagamento pagamento)
    {
        _context.Pagamentos.Add(pagamento);
    }

    public void Atualizar(int id, Pagamento pagamento)
    {
        throw new NotImplementedException();
    }

    public void Deletar(int id)
    {
        throw new NotImplementedException();
    }
}