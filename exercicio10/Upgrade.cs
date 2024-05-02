class Upgrade : Voo
{
    public int NumReserva;

    public string Nome;

    public string ClassAtual;

    public string ClassAntigo;

    private string numeroVoo;
    private string nomePassageiro;
    private string classeAtual;
    private string novaClasse;

    public Upgrade(string numeroVoo, string nomePassageiro, string classeAtual, string novaClasse)
    {
        this.numeroVoo = numeroVoo;
        this.nomePassageiro = nomePassageiro;
        this.classeAtual = classeAtual;
        this.novaClasse = novaClasse;
    }

    public void ReservarVoo()
    {
        Console.WriteLine($"Reserva do passageiro {nomePassageiro} para o voo {numeroVoo} com upgrade de classe de {classeAtual} para {novaClasse} realizada com sucesso.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine($"Reserva do passageiro {nomePassageiro} para o voo {numeroVoo} com upgrade de classe cancelada com sucesso.");
    }

    public void VerificarStatus()
    {
        Console.WriteLine($"Status da reserva do passageiro {nomePassageiro} para o voo {numeroVoo}: Confirmada com upgrade de classe de {classeAtual} para {novaClasse}.");
    }
}