class Inter : Transacao
{
    public double Saldo { get; set; }

    public void NovoSaldo(Transacao valor)
    {
        if (valor.Tipo == "Pagar")
        {
            Saldo -= valor.Valor;
        }
        else if (valor.Tipo == "Reembolsar")
        {
            Saldo += valor.Valor;
        }
    }

}