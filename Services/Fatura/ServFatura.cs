using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class ServFatura : IServFatura
    {
        private readonly IRepFatura _repFatura;

        public ServFatura(IRepFatura repFatura)
        {
            _repFatura = repFatura;
        }

        public Fatura Alterar(Fatura faturaEditada)
        {
            var fatura = _repFatura.AlterarFatura(faturaEditada);

            return fatura;
        }

        public Fatura ListarFaturaPorId(int id)
        {
            var fatura = _repFatura.ListarFaturaPorId(id);

            return fatura;
        }

        public List<Fatura> ListarFaturas()
        {
            var faturas = _repFatura.ListarFaturas();

            return faturas;
        }

        public void Remover(Fatura fatura)
        {
            _repFatura.RemoverFatura(fatura);
        }

        public Fatura SalvarFatura(Fatura novaFatura)
        {
            var fatura = _repFatura.SalvarFatura(novaFatura);

            return fatura;
        }
    }
}
