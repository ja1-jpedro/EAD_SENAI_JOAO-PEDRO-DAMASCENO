public class Pessoa_Juridica : Clientes
{
    public string CNPJ { get; set; }
    public string IE { get; set; }

    public override void PagarImposto(float v)
    {
        Valor = v;
        ValorImposto = Valor * 0.2f;
        Total = Valor + ValorImposto;
        Console.WriteLine($"Pessoa Jurídica - Imposto calculado: {ValorImposto}");
    }
}
