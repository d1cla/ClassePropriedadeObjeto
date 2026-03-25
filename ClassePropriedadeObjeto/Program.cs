//criei uma classe chamada Pessoa com as propriedades Nome e Idade, e depois criei um objeto do tipo Pessoa e atribui valores a essas propriedades.
class Pessoa
{
    //Nome usa o tipo string para texto, e Idade usa o tipo int para números inteiros. get significa que a propriedade pode ser lida, e set significa que a propriedade pode ser escrita.
    //Propriedades Nome e Idade são usadas para armazenar informações sobre a pessoa, como seu nome e idade. Essas propriedades permitem que você acesse e modifique os valores associados a cada instância da classe Pessoa.
    public string Nome { get; set; }
    public int Idade { get; set; }
}
//pessoa 1 é o objeto do tipo Pessoa, e estou atribuindo os valores "Dicla" para a propriedade Nome e 40 para a propriedade Idade.
Pessoa pessoa 1 = new Pessoa(); 
pessoa 1.Nome = "Dicla";
pessoa 1.Idade = 40;

