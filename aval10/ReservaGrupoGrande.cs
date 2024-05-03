public class ReservaGrupoGrande : IReserva
{
  public bool Reservado { get; set; }
  public List<Passageiro> Passageiros = new List<Passageiro>();

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