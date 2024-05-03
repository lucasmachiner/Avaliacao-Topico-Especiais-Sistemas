
namespace avaliacao.aval9
{
    public class CartaoCredito : IMetodoPagamento
    {
        public int Parcelas { get; set; }
        public double ValorParcelas { get; set; }
        public double ValorTotal { get; set; }
        public bool Status { get; set; }
        public void Pagamento()
        {
            if (!Status)
            {
                ValorParcelas = ValorTotal / Parcelas;
                Console.WriteLine("Pagamento em Crédito realizado, com parcelas no valor de: " + ValorParcelas);
                Status = true;
            }
            else
            {
                Console.WriteLine("O pagamento já foi realizado");
            }

        }
    }
}