public class Locadora
{
  public List<Filme> Filmes = new List<Filme>();
  public void AdicionarFilme(Filme f)
  {
    Filmes.Add(f);
  }
  public void LocarFilme(string titulo)
  {

    for (int i = 0; i < Filmes.Count; i++)
    {
      if (Filmes[i].Titulo == titulo)
      {
        if (Filmes[i].Disponivel)
        {
          Console.WriteLine("Locação realizada com sucesso");
          Filmes[i].Disponivel = false;

        }
        else
        {
          Console.WriteLine("Esse filme está indisponivel");
        }
      }
    }
  }
  public void DevolverFilme(string titulo)
  {
    for (int i = 0; i < Filmes.Count; i++)
    {
      if (Filmes[i].Titulo == titulo)
      {
        Console.WriteLine("Devolução realizada");
        Filmes[i].Disponivel = true;
      }
    }
  }
}