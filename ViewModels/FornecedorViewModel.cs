namespace EstoqueVendasSQLITE.ViewModels
{
    public class FornecedorViewModel
    {
        public string FornecedorNome { get; set; } = string.Empty;
        public int QuantidadeVendida { get; set; }
        public decimal? SomaVendas { get; set; }
        public decimal? LucroTotal { get; set; }
    }
}
