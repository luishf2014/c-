class Regular : Voo
{
    public int NumReserva;

    public string Nome;
    private string numeroVoo;
    private string nomePassageiro;

    public ReservaVooRegular(string numeroVoo, string nomePassageiro)
    {
        this.numeroVoo = numeroVoo;
        this.nomePassageiro = nomePassageiro;
    }

    public void ReservarVoo()
    {
        Console.WriteLine($"Reserva do passageiro {nomePassageiro} para o voo {numeroVoo} realizada com sucesso.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine($"Reserva do passageiro {nomePassageiro} para o voo {numeroVoo} cancelada com sucesso.");
    }

    public void VerificarStatus()
    {
        Console.WriteLine($"Status da reserva do passageiro {nomePassageiro} para o voo {numeroVoo}: Confirmada.");
    }
}