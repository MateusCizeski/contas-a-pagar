﻿namespace api_contas_pagar.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public ICollection<Fatura> Faturas { get; set; }
    }
}
