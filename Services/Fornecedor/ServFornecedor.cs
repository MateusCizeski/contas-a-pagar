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

        public Fornecedor ListarFornecedorPorId(int id)
        {
            var fornecedor = _repFornecedor.ListarFornecedorPorId(id);

            return fornecedor;
        }

        public Fornecedor Alterar(Fornecedor fornecedor)
        {
            var fornec = _repFornecedor.Alterar(fornecedor);

            return fornec;
        }

        public void Remover(Fornecedor fornecedor)
        {
            _repFornecedor.RemoverFornecedor(fornecedor);
        }
    }
}
