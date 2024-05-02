public abstract class Meio : IMetodoPagamento
{   
    public abstract void Realizar(double valor);
    public abstract string Verificar();
}
