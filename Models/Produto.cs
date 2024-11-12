using System.ComponentModel.DataAnnotations;

namespace EstoqueVendasSQLITE.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do produto")]
        public string ProdutoNome { get; set; }
        [Required(ErrorMessage = "Informe o fornecedor")]
        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
