class Boleto : Meio
{
    private string codBoleto;

    public Boleto(string codBoleto)
    {
        this.codBoleto = codBoleto;
    }

    public override void Realizar(double valor)
    {
        Console.WriteLine($"Emitindo boleto para pagamento de R${valor}...");
        Console.WriteLine($"Código do boleto: {codBoleto}");
        Console.WriteLine("Por favor, realize o pagamento do boleto.");
    }

    public override string Verificar()
    {
        return "Pagamento com boleto bancário verificado.";
    }
}