using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class ServFornecedor : IServFornecedor
    {
        private readonly IRepFornecedor _repFornecedor;

        public ServFornecedor(IRepFornecedor repFornecedor)
        {
            _repFornecedor = repFornecedor;
        }

        public Fornecedor SalvarFornecedor(Fornecedor fornecedor)
        {
            var fornec = _repFornecedor.Salvar(fornecedor);

            return fornec;
        }

        public List<Fornecedor> ListarFornecedores()
        {
            var fornecedores = _repFornecedor.ListarFornecedores();

            return fornecedores;
        }
    }
}
