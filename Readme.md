 

### 1. Explique o que é herança em orientação a objetos e como ela é implementada em C#. Dê um exemplo prático de como a herança pode ser utilizada em um sistema de gerenciamento de funcionários. 
 - **R=** Herança em orientação é quando herdamos um classe para nossa classe, definimos geralmente essa classe como uma classe abstrata que definimos como se fosse generica ela atende para varias outras coisas. Por exemplo quando eu quero criar um Funcionario eu sei que o funcionario ele é uma pessoa, logo a pessoa é uma classe abstrata, pois não tem como eu ser um funcionario sem antes ser uma pessoa, então criamos essa classe Pessoa e na classe funcionario herdamos ela, pois na classe Pessoa teremos tudo que define uma pessoa: nome, idade, data de nacismento, registro. Informações padrão para uma pessoa e no funcionario teremos propriedades que definem ele um funcionario.

 ### 2. O que são interfaces em orientação a objetos e qual é a sua importância na construção de sistemas em C#? Dê um exemplo de como uma interface pode ser utilizada para garantir a interoperabilidade entre diferentes classes em um sistema de pagamento online.
 - **R=** Interfaces é um contrato entre classe, um contrato de metodos que estabelecemos para ser herdado em cada tipo diferente de classes. Exemplo, temos um pedagio em que cobra valores a partir de cada caracteristica do veiculos, logo esses veiculos são classes diferentes que contem as informações unicas desses veiculos. Entao criamos uma interface com metodo de calculo do pedagio que retorna o resultado do calculo. Herdamos essa interface em nas classes dos veiculos e realizamos os calculos com base na informação dos veiculos.

 ### 3. Diferencie sobrecarga e sobreposição (ou sobrescrita) e forneça exemplos de cada um em C#.
 - **R=** A sobreposição ela vai alterando a assinatura do metodo, de maneira em que possa receber um ou mais tipo de parametros, repetir os mesmos tipos e a ordem dos parametros não funciona; Sobrecarga sobreescreve um metodo herdado ou de alguma classe Base(System) utilizando o **virtual** na declaração desse metodo e na classe que irá herdar caso queira fazer sobre carga desse metodo utiliza o **override**.
 Sobreposição:
```
public void AdicionarPessoa(string nome) 
{

}

public void AdicionarPessoa(string nome, int idade) 
{

}

public void AdicionarPessoa(int idade, string nome) 
{

}

```

 Sobrecarga:
```
public classe Pai 
{
  public Pessoa pessoa {get; set;}

  public virtual void AdicionarPessoa(Pessoa p) {
    pessoa = p;
  }
}


public classe Filho : Pai
{
  public string Nome {get; set;}
  public int Idade {get; set;}
  public override void AdicionarPessoa(string nome, int idade) 
  {
    Nome = nome;
    Idade = idade;
  }
}

```