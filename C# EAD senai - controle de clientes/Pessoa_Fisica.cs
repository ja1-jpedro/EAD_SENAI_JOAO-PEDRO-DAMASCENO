public class Pessoa_Fisica : Clientes
{
    public string CPF { get; set; }
    public string RG { get; set; }

    public override void PagarImposto(float v)
    {
        Valor = v;
        ValorImposto = Valor * 0.15f; 
        Total = Valor + ValorImposto;
        Console.WriteLine($"Pessoa Física - Imposto calculado: {ValorImposto}");
    }
}
