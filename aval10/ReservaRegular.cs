public class ReservaRegular : IReserva
{
  public virtual Passageiro Passageiro { get; set; }
  public bool Reservado { get; set; }
  public void ReservarVoo()
  {
    Reservado = true;
    Console.WriteLine("Reserva realizada!");
  }
  public void CancelarReserva()
  {
    Reservado = false;
    Console.WriteLine("Reserva Cancelada");
  }
  public void VerificarReserva()
  {
    if (Reservado)
    {
      Console.WriteLine("Reserva confirmada");
    }
    else
    {
      Console.WriteLine("Reserva Cancelada");
    }
  }
}