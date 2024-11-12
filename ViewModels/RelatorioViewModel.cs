namespace EstoqueVendasSQLITE.ViewModels
{
    public class RelatorioViewModel
    {
        public string ProdutoNome { get; set; } = string.Empty;
        public int QuantidadeVendida { get; set; }
        public int QuantidadeAtivada { get; set; }
        public decimal? SomaVendas { get; set; }
        public decimal? LucroTotal { get; set; }
    }

}
