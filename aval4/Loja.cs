namespace Avaliacao.Questao4;

public class Loja
{
  public List<Produto> Produtos = new List<Produto>();
  public void AdicionarProduto(Produto produto)
  {
    Produtos.Add(produto);
  }
  public void RemoverProduto(String nome)
  {
    Produtos.RemoveAll(x => x.Nome == nome);
  }

  public double CalcularValorTotalProduto(String nome)
  {
    double total = 0;
    for (int i = 0; i < Produtos.Count; i++)
    {
      if (Produtos[i].Nome == nome)
      {
        total = Produtos[i].Preco * Produtos[i].QtdEmEstoque;
      }
    }
    return total;
  }
  public void ListarProdutos()
  {
    foreach (Produto produto in Produtos)
    {
      Console.WriteLine(produto.Nome);
    }
  }
}