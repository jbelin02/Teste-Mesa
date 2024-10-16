public class Program
{
    public static void Main()
    {
        Console.WriteLine("Quantas entradas você deseja inserir?");
        int qtd = int.Parse(Console.ReadLine());

        double[] ent = new double[qtd];
        double[] tx = new double[qtd];
        double[] pm = new double[qtd];
        double[] resg = new double[qtd];

       
        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"Digite o valor da entrada {i + 1}:");
            ent[i] = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Digite a taxa de juros {i + 1} (em decimal, ex: 0,03 para 3%):");
            tx[i] = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Digite o período (em meses) para a entrada {i + 1}:");
            pm[i] = double.Parse(Console.ReadLine() ?? "0");
        }

       
        Poo investimento = new Poo(ent, tx, pm);

        
        investimento.calcRend();

        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"Digite o valor do resgate no 5º mês para a entrada {i + 1}:");
            resg[i] = double.Parse(Console.ReadLine() ?? "0");
        }

        investimento.resgate(resg);
        investimento.ShowResult(resg);
    }
}