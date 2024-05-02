class Grupo : Voo
{
    public int NumReserva;

    public string[] Nome;

    public Grupo(string numeroVoo, string[] nomesPassageiros)
    {
        this.numeroVoo = numeroVoo;
        this.nomesPassageiros = nomesPassageiros;
    }

    public void ReservarVoo()
    {
        Console.WriteLine($"Reserva para grupo grande para o voo {numeroVoo} com {nomesPassageiros.Length} passageiros realizada com sucesso.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine($"Reserva para grupo grande para o voo {numeroVoo} cancelada com sucesso.");
    }

    public void VerificarStatus()
    {
        Console.WriteLine($"Status da reserva para o grupo grande no voo {numeroVoo}: Confirmada para {nomesPassageiros.Length} passageiros.");
    }
}