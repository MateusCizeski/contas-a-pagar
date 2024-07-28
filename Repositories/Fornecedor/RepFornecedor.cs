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

        public Fornecedor Alterar(Fornecedor fornecedor)
        {
            _connectionContext.Fornecedores.Update(fornecedor);
            _connectionContext.SaveChanges();

            return fornecedor;
        }

        public List<Fornecedor> ListarFornecedores()
        {
            var fornecedores = _connectionContext.Fornecedores.ToList();

            return fornecedores;
        }

        public Fornecedor ListarFornecedorPorId(int id)
        {
            var fornecedor = _connectionContext.Fornecedores.Where(f => f.Id == id).FirstOrDefault();

            if(fornecedor == null)
            {
                throw new Exception("Fornecedor não encontrado.");
            }

            return fornecedor;
        }

        public void RemoverFornecedor(Fornecedor fornecedor)
        {
            _connectionContext.Fornecedores.Remove(fornecedor);
            _connectionContext.SaveChanges();
        }

        public Fornecedor Salvar(Fornecedor fornecedor)
        {
            _connectionContext.Fornecedores.Add(fornecedor);
            _connectionContext.SaveChanges();

            return fornecedor;
        }
    }
}
