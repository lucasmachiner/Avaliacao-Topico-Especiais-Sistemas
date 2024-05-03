public class Frances : Curso
{
  public List<Aluno> Alunos = new List<Aluno>();
  public double Media { get; set; }
  public double CalcMedia(string matricula)
  {
    for (int i = 0; i < Alunos.Count; i++)
    {
      if (Alunos[i].Matricula == matricula)
      {
        Media = (Alunos[i].Nota1 + Alunos[i].Nota2 + Alunos[i].Nota3) / 3;
        Alunos[i].Concluido = Media > 6;
      }
      else
      {
        Console.WriteLine("Aluno não encontrado");
      }
    }
    return Media;
  }
  public void GerarCertificado(string matricula)
  {
    for (int i = 0; i < Alunos.Count; i++)
    {
      if (Alunos[i].Matricula == matricula)
      {
        if (Alunos[i].Concluido)
        {
          Console.WriteLine("Gerando certificado de Francês " + NivelCurso + " do aluno " + Alunos[i].Nome);
        }
        else
        {
          Console.WriteLine("Esse Aluno não concluiu o curso");
        }
      }
      else
      {
        Console.WriteLine("Aluno não encontrado");
      }
    }
  }

}