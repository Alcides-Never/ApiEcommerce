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
        return _context.Pagamentos.FirstOrDefault(p => p.IdPagamento == id);
    }

    public void Cadastrar(Pagamento pagamento)
    {
        _context.Pagamentos.Add(pagamento);
    }

    public void Atualizar(int id, Pagamento pagamento)
    {
        Pagamento pagamentoEncontrado = _context.Pagamentos.Find(id);
        if (pagamentoEncontrado == null)
        {
            throw new Exception();
        }

        pagamentoEncontrado.FormaPagamento = pagamento.FormaPagamento;
        pagamentoEncontrado.Status = pagamento.Status;
        pagamentoEncontrado.Data = pagamento.Data;
        pagamentoEncontrado.IdPedido = pagamento.IdPedido;

        _context.SaveChanges();

    }

    public void Deletar(int id)
    {
        Pagamento pagamentoEncontrado = _context.Pagamentos.Find(id);
        if (pagamentoEncontrado == null)
        {
            throw new Exception();
        }

        _context.Pagamentos.Remove(pagamentoEncontrado);
        _context.SaveChanges();
    }
}