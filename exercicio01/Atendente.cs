
class Atendente : Pessoa
{
    public double Comissao = 0.20;
    public double Salario {get;set;}
    
    public void AtualizarPagode(Pessoa Cargo)
    {
        if(Cargo.Cargo == "Atendente"){
            Salario = Cargo.Valor + (Cargo.Valor * Comissao);
        }
        else if(Cargo.Cargo == "Gerente"){
            Salario = Cargo.Valor + (Cargo.Valor * Comissao);
        }
    }

}



