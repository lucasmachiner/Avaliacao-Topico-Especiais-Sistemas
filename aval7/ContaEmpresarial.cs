public class ContaEmpresarial : Conta
{
  public double SaldoMinimo { get; set; }
  public void AdicionarSaldo(double saldo)
  {
    SaldoMinimo = saldo;
  }
}