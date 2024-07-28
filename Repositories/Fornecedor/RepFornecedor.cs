using api_contas_pagar.DTOs.Fornecedor;
using api_contas_pagar.Models;
using Microsoft.AspNetCore.Connections;

namespace api_contas_pagar
{
    public class RepFornecedor : IRepFornecedor
    {
        private readonly ConnectionContext _connectionContext;

        public RepFornecedor(ConnectionContext connectionContext)
        {
            _connectionContext = connectionContext;
        }

        public Fornecedor Alterar(AlterarFornecedorDTO dto)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> ListarFornecedores()
        {
            var fornecedores = _connectionContext.fornecedores.ToList();

            return fornecedores;
        }

        public Fornecedor ListarFornecedorPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoverFornecedor(int id)
        {
            throw new NotImplementedException();
        }

        public Fornecedor Salvar(Fornecedor fornecedor)
        {
            _connectionContext.fornecedores.Add(fornecedor);
            _connectionContext.SaveChanges();

            return fornecedor;
        }
    }
}
