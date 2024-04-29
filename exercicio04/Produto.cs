class Produto
{
    public string Nome {get; set;}
    public double Preco {get; set;}
    public double QuantidadeEmEstoque {get; set;}

    public Produto(string nome, double preco, double quantidadeEmEstoque)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }


    public void Adicionar(int quant)
    {
        if (quant > 0)
        {
            QuantidadeEmEstoque += quant;
            Console.WriteLine($"Adicionado {quant} unidades ao produto {Nome}.");
            Console.WriteLine($"Agora tem {QuantidadeEmEstoque} unidades em estoque.");
        }
        else
        {
            Console.WriteLine("Quantidade deve ser maior que zero.");
        }
    }

    public void Remover(int quant)
    {
        if (quant > 0 && QuantidadeEmEstoque >= quant)
        {
            QuantidadeEmEstoque -= quant;
             Console.WriteLine($"Adicionado {quant} unidades ao produto {Nome}.");
            Console.WriteLine($"Agora tem {QuantidadeEmEstoque} unidades em estoque.");
        }
        else
        {
            Console.WriteLine("Quantidade deve ser maior, menor ou igual à quantidade em estoque ou zero.");
        }
    }
    public double TotalEmEstoque(){
        return Preco * QuantidadeEmEstoque;
    }
}