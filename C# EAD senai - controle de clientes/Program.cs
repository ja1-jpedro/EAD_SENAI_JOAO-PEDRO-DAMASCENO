using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cadastro de Clientes\n");

        // Criando um objeto Pessoa_Fisica
        Pessoa_Fisica pf = new Pessoa_Fisica();
        Console.WriteLine("Cadastro Pessoa Física");
        Console.Write("Nome: ");
        pf.Nome = Console.ReadLine();
        Console.Write("Endereço: ");
        pf.Endereco = Console.ReadLine();
        Console.Write("CPF: ");
        pf.CPF = Console.ReadLine();
        Console.Write("RG: ");
        pf.RG = Console.ReadLine();
        Console.Write("Valor: ");
        pf.Valor = float.Parse(Console.ReadLine());
        pf.PagarImposto(pf.Valor);
        Console.WriteLine($"Total com imposto: {pf.Total}\n");

        // Criando um objeto Pessoa_Juridica
        Pessoa_Juridica pj = new Pessoa_Juridica();
        Console.WriteLine("Cadastro Pessoa Jurídica");
        Console.Write("Nome: ");
        pj.Nome = Console.ReadLine();
        Console.Write("Endereço: ");
        pj.Endereco = Console.ReadLine();
        Console.Write("CNPJ: ");
        pj.CNPJ = Console.ReadLine();
        Console.Write("IE: ");
        pj.IE = Console.ReadLine();
        Console.Write("Valor: ");
        pj.Valor = float.Parse(Console.ReadLine());
        pj.PagarImposto(pj.Valor);
        Console.WriteLine($"Total com imposto: {pj.Total}\n");

        Console.WriteLine("Cadastro concluído!");
    }
}
