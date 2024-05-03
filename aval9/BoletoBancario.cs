public class BoletoBancario : IMetodoPagamento
{
  public double ValorTotal { get; set; }
  public bool Status { get; set; }
  public void Pagamento()
  {
    if (!Status)
    {
      Console.WriteLine("Pagamento em boleto realizado");
      Status = true;
    }
    else
    {
      Console.WriteLine("O pagamento já foi realizado");
    }

  }
}