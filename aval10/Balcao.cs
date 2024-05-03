public class Balcao
{
  public void ReservarVoo(IReserva reserva)
  {
    reserva.ReservarVoo();
  }
  public void VerificarReserva(IReserva reserva)
  {
    reserva.VerificarReserva();
  }
  public void CancelarReserva(IReserva reserva)
  {
    reserva.CancelarReserva();
  }

}