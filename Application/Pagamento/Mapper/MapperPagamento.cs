using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class MapperPagamento : IMapperPagamento
    {
        public Pagamento MapearEdicao(AlterarPagamentoDTO dto, Pagamento pagamento)
        {
            pagamento.Valor_pagamento = dto.Valor_pagamento;
            pagamento.Data_pagamento = dto.Data_pagamento;
            pagamento.CodigoMetodoPagamento = dto.CodigoMetodoPagamento;

            return pagamento;
        }

        public Pagamento MapearInsercao(SalvarPagamentoDTO dto)
        {
            Pagamento pagamento = new Pagamento()
            {
                Valor_pagamento = dto.Valor_pagamento,
                Data_pagamento = DateTime.UtcNow,
                CodigoMetodoPagamento = dto.CodigoMetodoPagamento
            };

            return pagamento;
        }
    }
}
