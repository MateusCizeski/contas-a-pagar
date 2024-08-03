using api_contas_pagar.Models;
using Microsoft.EntityFrameworkCore;

namespace api_contas_pagar
{
    public class RepFaturaPagamento : IRepFaturaPagamento
    {
        private readonly ConnectionContext _connectionContext;

        public RepFaturaPagamento(ConnectionContext connectionContext)
        {
            _connectionContext = connectionContext;
        }

        public FaturaPagamento Alterar(FaturaPagamento faturaPagamento)
        {
            _connectionContext.FaturaPagamentos.Update(faturaPagamento);
            _connectionContext.SaveChanges();

            var fatura = _connectionContext.Faturas.Include(f => f.FaturaPagamentos).FirstOrDefault(f => f.Id == faturaPagamento.CodigoFatura);

            if(fatura != null)
            {
                AtualizarStatusFatura(fatura);
            }

            return faturaPagamento;
        }

        public List<FaturaPagamento> Listar()
        {
           var faturasPagamentos = _connectionContext.FaturaPagamentos.ToList();

            return faturasPagamentos;
        }

        public FaturaPagamento ListarPorId(int codigoPagamento, int codigoFatura)
        {
            var faturaPagamento = _connectionContext.FaturaPagamentos.Where(fp => fp.CodigoPagamento == codigoPagamento &&
                                                                                  fp.CodigoFatura == codigoFatura).FirstOrDefault();

            if(faturaPagamento == null)
            {
                throw new Exception("Registro não encontrado");
            }

            return faturaPagamento;
        }

        public void Remover(FaturaPagamento faturaPagamento)
        {
            _connectionContext.FaturaPagamentos.Remove(faturaPagamento);
            _connectionContext.SaveChanges();
        }

        public FaturaPagamento Salvar(FaturaPagamento faturaPagamento)
        {
            var fatura = _connectionContext.Faturas.Find(faturaPagamento.CodigoFatura);

            if(fatura == null)
            {
                throw new Exception($"Fatura de código {faturaPagamento.CodigoFatura} não encontrado.");
            }

            var pagamento = _connectionContext.Pagamentos.Find(faturaPagamento.CodigoPagamento);

            if(pagamento == null)
            {
                throw new Exception($"Pagamento de código {faturaPagamento.CodigoPagamento} não encontrado.");
            }

           _connectionContext.FaturaPagamentos.Add(faturaPagamento);
           _connectionContext.SaveChanges();

            AtualizarStatusFatura(fatura);

            return faturaPagamento;
        }

        public void AtualizarStatusFatura(Fatura fatura)
        {
            decimal somaPagamentos = fatura.FaturaPagamentos.Sum(fp => fp.ValorPago);

            if(DateTime.Now > fatura.Data_vencimento)
            {
                fatura.Status = StatusFatura.Vencida;
            }else
            {
                if(somaPagamentos == 0)
                {
                    fatura.Status = StatusFatura.Pendente;
                }
                else if(somaPagamentos < fatura.Valor)
                {
                    fatura.Status = StatusFatura.ParcialmentePago;
                }
                else if(somaPagamentos >= fatura.Valor)
                {
                    fatura.Status = StatusFatura.Pago;
                }
            }


            _connectionContext.Faturas.Update(fatura);
            _connectionContext.SaveChanges();
        }
    }
}
