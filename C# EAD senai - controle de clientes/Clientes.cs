
public class Clientes
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public float Valor { get; set; }
    protected float ValorImposto { get; set; }
    protected float Total { get; set; }

    public virtual void PagarImposto(float v)
    {
        Valor = v;
        ValorImposto = Valor * 0.1f; 
        Total = Valor + ValorImposto;
        Console.WriteLine($"Imposto calculado: {ValorImposto}");
    }
}

