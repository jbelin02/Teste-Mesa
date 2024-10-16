using System;

public class Poo
{
    public double[] ent { get; set; }  
    public double[] tx { get; set; }   
    public double[] pm { get; set; }   
    public double[] rf { get; set; }   
    public double[] sr { get; set; }   

    
    public Poo(double[] ent, double[] tx, double[] pm)
    {
        this.ent = ent;
        this.tx = tx;
        this.pm = pm;
        this.rf = new double[ent.Length];
        this.sr = new double[ent.Length];
    }


    public void calcRend()
    {
        for (int i = 0; i < ent.Length; i++)
        {
            rf[i] = ent[i] * Math.Pow(1 + tx[i], pm[i]);
        }
    }

    public void resgate(double[] resg, int mesResg = 5)
    {
        for (int i = 0; i < ent.Length; i++)
        {
   
            double rendResg = ent[i] * Math.Pow(1 + tx[i], mesResg);

            if (resg[i] > rendResg)
            {
                resg[i] = rendResg;
            }

      
            sr[i] = rendResg - resg[i];
        }
    }


    public void ShowResult(double[] resg)
    {
        Console.WriteLine("\nResultados:");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("| Mês   |   Rendimento   | Resgate Parcial | Saldo Líquido | Rendimento Restante | Saldo Restante |");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

        for (int i = 0; i < ent.Length; i++)
        {
            double rendRestante = rf[i] - sr[i];  
            double saldoLiquido = sr[i]; 

            Console.WriteLine($"| {i + 1}     |   {rf[i]:F2}      |     {resg[i]:F2}        |      {saldoLiquido:F2}      |         {rendRestante:F2}          |       {sr[i]:F2}       |");
        }

        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
    }
}


