﻿using api_contas_pagar.DTOs;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IMapperFornecedor
    {
        public Fornecedor MapearInsercao(SalvarFornecedorDTO dto);
    }
}
