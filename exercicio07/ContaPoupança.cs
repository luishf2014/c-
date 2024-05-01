class ContaPoupança : Contas
{
    public double juros = 0.18;

    public void CalcJuros(){
        Saldo -= Saldo * juros;
        Console.WriteLine("Saldo após o juros de 18%: " + Saldo);
    }

}