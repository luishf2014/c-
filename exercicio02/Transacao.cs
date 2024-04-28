class Transacao : Ipagamento
{
    public string Tipo { get; set; }
    public double Valor { get; set; }
    public int NumConta { get; set; }

    public String NomeConta {get; set;}

    public void Exibir(string Tipo, double valor, int NumConta, string NomeConta){
        Console.WriteLine($"Tipo (Pagar/Reembolsar): {Tipo}");
        Console.WriteLine($"Valor de transferencia: {valor}");
        Console.WriteLine($"Numero da Conta: {NumConta}");
        Console.WriteLine($"Nome da Conta: {NomeConta}");
    }

}