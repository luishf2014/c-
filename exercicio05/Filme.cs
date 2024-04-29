public class Filme
{
    public String Titulo { get; set; }
    public String Genero { get; set; }
    public double Duracao { get; set; }
    public string Disponivel = "Disponivel";

    public Filme(String titulo, String genero, double duracao)
    {
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
    }

    public void Estado()
    {
        Console.WriteLine("Este filme está " + Disponivel + " para locação.");
    }

    public void Locacao()
    {
        if (Disponivel == "Disponivel")
        {
            Disponivel = "Indisponivel";
            Console.WriteLine("Filme alugado com sucesso!!!");
        }
        else
        {
            Console.WriteLine("Filme indisponivél pra locação...");
        }
    }

    public void Devolucao()
    {
        if (Disponivel == "Indisponivel")
        {
            Disponivel = "Disponivel";
            Console.WriteLine("Filme devolvido com sucesso!!!");
        }
    }
}