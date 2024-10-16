using System;

public class Ex3
{
    public static void Seis()
{
    double[] ent = new double[3];
    double[] tx = new double[3];
    double p = 8.33;
    double rf = 0;

    
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Digite o valor da entrada " + (i + 1) + ":");
        ent[i] = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o valor da taxa " + (i + 1) + " (em decimal):");
        tx[i] = double.Parse(Console.ReadLine() ?? "0");
    }

    
    Console.WriteLine("\nEntrada\t\tTaxa\t\tRendimento Futuro");
    Console.WriteLine("---------------------------------------------------");

    
    for (int i = 0; i < 3; i++)
    {
        double rendimentoFuturo = ent[i] * Math.Pow(1 + tx[i], p);
        Console.WriteLine($"{ent[i]:F2}\t\t{tx[i]:F2}\t\t{rendimentoFuturo:F2}");
    }

    
    for (int i = 0; i < 3; i++)
    {
        rf += ent[i] * Math.Pow(1 + tx[i], p);
    }

    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine($"Total Rendimento Futuro: R$ {rf:F2}");
}


    public static void Sete()
{
    double[] ent = new double[3];  
    double[] tx = new double[3];   
    double p = 8.33;  
    double rf = 0;    
    double[] rm = new double[3];
    double[] sr = new double[3];

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Digite o valor da entrada " + (i + 1) + ":");
        ent[i] = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o valor da taxa " + (i + 1) + " (em decimal, ex: 0,03 para 3%):");
        tx[i] = double.Parse(Console.ReadLine() ?? "0");
    }


    for (int i = 0; i < 3; i++)
    {

        rf = ent[i] * Math.Pow(1 + tx[i], p);
        
        
        rm[i] = ent[i] * Math.Pow(1 + tx[i], 5);

        double resgate = 0;

        
        Console.WriteLine("Você deseja realizar um saque no 5º mês para a entrada " + (i + 1) + "? (s/n)");
        string res = Console.ReadLine().ToLower();

        if (res == "s")
        {
            Console.WriteLine("Digite o valor do saque que deseja realizar:");
            resgate = double.Parse(Console.ReadLine() ?? "0");

            if (resgate > rm[i])
            {
                Console.WriteLine("O resgate foi definido pelo valor total da conta por execer o valor do saque.");

                resgate = rm[i];  
            }

            
            sr[i] = rm[i] - resgate;
        }
        else
        {

            sr[i] = rm[i];  
            resgate = 0;

        }

        Console.WriteLine("\n Entrada \t \t Taxa \t \t Rendimento Futuro \t Resgate \t \t Saldo Líquido Restante \t Rendimento Restante");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"{ent[i]:F2} \t \t {tx[i] * 100:F2}% \t \t {rf:F2} \t \t {resgate:F2} \t \t {sr[i]:F2} \t \t {rf - sr[i]:F2}");
    }

    
}
   

}


