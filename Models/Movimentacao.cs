namespace Models
{
    public class Movimentacao
    {
        public int IdMovimentacao { get; set; }
        public char Natureza { get; set; }
        public decimal Valor { get; set; }
        public Categoria Categoria { get; set; }
        public Usuario Usuario { get; set; }
        public Conta Conta { get; set; }
    }
}