
public class CartaoCredito : Meio
{
    public string NumCartao;
    public string DataVal;
    public string CodigoSeg;

    public CartaoCredito(string numCartao, string dataVal, string codigoSeg)
    {
        this.NumCartao = numCartao;
        this.DataVal = dataVal;
        this.CodigoSeg = codigoSeg;
    }

    public override void Realizar(double valor)
    {
        Console.WriteLine($"Processando pagamento de R${valor} com cartão de crédito...");
        Console.WriteLine($"Númeor do Cartão: {NumCartao}");
        Console.WriteLine($"Validade: {DataVal}");
        Console.WriteLine($"Código: {CodigoSeg}");
        Console.WriteLine("Pagamento realizado com sucesso!");
    }
     
    public override string Verificar()
    {
        return "Pagamento com cartão de crédito verificado.";
    }
}