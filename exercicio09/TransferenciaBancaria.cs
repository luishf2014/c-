class TransferenciaBancaria : Meio
{
    private string bancoDestino;
    private string numeroConta;

    public TransferenciaBancaria(string bancoDestino, string numeroConta)
    {
        this.bancoDestino = bancoDestino;
        this.numeroConta = numeroConta;
    }

    public override void Realizar(double valor)
    {
        Console.WriteLine($"Transferência de R${valor}");
        Console.WriteLine($"{bancoDestino}");
        Console.WriteLine($"Número da Conta: {numeroConta}");
        Console.WriteLine("Transferência realizada com sucesso!");
    }

    public override string Verificar()
    {
        return "Pagamento com transferência bancária verificado.";
    }   
}