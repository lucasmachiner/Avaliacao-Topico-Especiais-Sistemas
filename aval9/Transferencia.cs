public class Transferencia : IMetodoPagamento
{
  public double ValorTotal { get; set; }
  public bool Status { get; set; }
  public void Pagamento()
  {
    if (!Status)
    {
      Console.WriteLine("Transferencia realizada");
      Status = true;
    }
    else
    {
      Console.WriteLine("O pagamento já foi realizado");
    }

  }
}