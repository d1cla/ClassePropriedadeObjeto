lass Pessoa
{
    //Nome usa o tipo string para texto, e Idade usa o tipo int para números inteiros. get significa que a propriedade pode ser lida, e set significa que a propriedade pode ser escrita.
    //Propriedades Nome e Idade são usadas para armazenar informações sobre a pessoa, como seu nome e idade. Essas propriedades permitem que você acesse e modifique os valores associados a cada instância da classe Pessoa.
    //Aqui criei a classe
    public string Nome { get; set; }
    public int Idade { get; set; }
}
class Program
{
    static void Main()
    {
        //Aqui criei o objeto, pessoa 1 é o objeto do tipo Pessoa, e estou atribuindo os valores "Dicla" para a propriedade Nome e 40 para a propriedade Idade.
        Pessoa pessoa1 = new Pessoa();
        //Aqui quando preenche os dados, são as propriedades Nome e Idade do objeto pessoa1 que estão sendo preenchidas com os valores "Dicla" e 40, respectivamente. Isso significa que a pessoa representada por pessoa1 tem o nome "Dicla" e tem 40 anos de idade.
        pessoa1.Nome = "Dicla";
        pessoa1.Idade = 40;
        //Embaixo peço pra mostrar as informações na tela, usando as propriedades Nome e Idade do objeto pessoa1 para exibir o nome e a idade da pessoa.
        Console.WriteLine($"Nome: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
    }
}
