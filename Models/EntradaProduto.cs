using System.ComponentModel.DataAnnotations;

namespace EstoqueVendasSQLITE.Models
{
    public class EntradaProduto
    {
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; } = DateTime.Now;
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = "Número de série é obrigatório")]
        public string NumeroSerie { get; set; }
        [DataType(DataType.Currency)]
        public decimal? PrecoCusto { get; set; }
        public bool? Ativo { get; set; } = true;
        public virtual Produto Produto { get; set;}
    }
}
