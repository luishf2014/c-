
class ContaEmpresarial : Contas
{
    public double saldoMin = 5000;

    public void VerificarSaldo(){
        if(Saldo < saldoMin){
            Console.WriteLine("Saldo abaixo do minimo");
        }
        else if (Saldo >= saldoMin){
            Console.WriteLine("Saldo suficiente");
        }
    }
  
}