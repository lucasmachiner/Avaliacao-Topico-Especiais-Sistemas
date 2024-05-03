// See https://aka.ms/new-console-template for more information
Loja loja = new Loja();

Produto produto1 = new Produto();
produto1.Nome = "Mouse";
produto1.Preco = 100;
produto1.QtdEmEstoque = 10;

loja.AdicionarProduto(produto1);

Produto produto2 = new Produto();
produto2.Nome = "Teclado";
produto2.Preco = 200;
produto2.QtdEmEstoque = 10;

loja.AdicionarProduto(produto2);

loja.ListarProdutos();
Console.WriteLine(loja.CalcularValorTotalProduto("Mouse"));

Console.WriteLine("----------------- Removendo -------------");

loja.RemoverProduto("Mouse");
loja.ListarProdutos();

Locadora locadora = new Locadora();
Filme filme = new Filme();

filme.Titulo = "Borat";
filme.Genero = "Comedia";
filme.Duracao = 1.60;
filme.Disponivel = true;

locadora.AdicionarFilme(filme);

Filme filme1 = new Filme();

filme1.Titulo = "Teste";
filme1.Genero = "Ação";
filme1.Duracao = 1.80;
filme1.Disponivel = false;

locadora.AdicionarFilme(filme1);

Console.WriteLine("----------------- Locar filmes -----------------");
locadora.LocarFilme("Borat");
locadora.LocarFilme("Teste");


Console.WriteLine("----------------- Devolver filmes -----------------");
locadora.DevolverFilme("Borat");

Ingles ingles = new Ingles();

Aluno aluno = new Aluno();
aluno.Nome = "Lucas Machiner";
aluno.Matricula = "123456";
aluno.Nota1 = 8;
aluno.Nota2 = 5;
aluno.Nota3 = 9;

ingles.NivelCurso = "Avançado";
ingles.AdicionarAluno(aluno);
ingles.CalcMedia("123456");
ingles.GerarCertificado("123456");


Balcao balcao = new Balcao();
Passageiro passageiro = new Passageiro();

passageiro.Nome = "Lucas Machiner";
passageiro.Cpf = "123";

ReservaRegular reservaRegular = new ReservaRegular();
reservaRegular.ReservarVoo();