class Curso
{
    public string Nome {get;set;}

    public double Nota1 {get;set;}

    public double Nota2 {get;set;}

    public double Nota3 {get;set;}


    public void Certificado(string Nome){
    }

    public void Media(double Nota1, double Nota2, double Nota3){
        double media = 0;
        media = (Nota1 + Nota2 + Nota3) / 3;
        Console.WriteLine($"Sua média é: {media}");

    }
}