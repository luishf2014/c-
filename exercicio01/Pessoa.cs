class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Valor {get;set;}
    public string Cargo {get;set;}

    public void Informacao(string Nome, int Idade, double valor, string Cargo)
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Salário: {valor}");
        Console.WriteLine($"Cargo: {Cargo}");
    }
}