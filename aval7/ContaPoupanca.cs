public class ContaPoupanca : Conta
{
  public double Juros { get; } = 0.05;
  public double Rendimento()
  {
    return Saldo * Juros;
  }
}