using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_contas_pagar.Models
{
    [Table("fornecedores", Schema = "contas_pagar")]
    public class Fornecedor
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }
        public ICollection<Fatura> Faturas { get; set; }
    }
}
