using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class RepFatura : IRepFatura
    {
        private readonly ConnectionContext _connectionContext;

        public RepFatura(ConnectionContext connectionContext)
        {
            _connectionContext = connectionContext;
        }

        public Fatura AlterarFatura(Fatura fatura)
        {
            fatura.Data_vencimento = DateTime.SpecifyKind(fatura.Data_vencimento, DateTimeKind.Utc);

            _connectionContext.Faturas.Update(fatura);
            _connectionContext.SaveChanges();

            return fatura;
        }

        public Fatura ListarFaturaPorId(int id)
        {
            var fatura = _connectionContext.Faturas.Where(f => f.Id == id).FirstOrDefault();

            if (fatura == null)
            {
                throw new Exception("Fatura não encontrado.");
            }

            return fatura;
        }

        public List<Fatura> ListarFaturas()
        {
            var faturas = _connectionContext.Faturas.ToList();

            return faturas;
        }

        public void RemoverFatura(Fatura fatura)
        {
            _connectionContext.Faturas.Remove(fatura);
            _connectionContext.SaveChanges();
        }

        public Fatura SalvarFatura(Fatura fatura)
        {
            fatura.Data_vencimento = DateTime.SpecifyKind(fatura.Data_vencimento, DateTimeKind.Utc);

            _connectionContext.Faturas.Add(fatura);
            _connectionContext.SaveChanges();

            return fatura;
        }
    }
}
