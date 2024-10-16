using System;

public class Ex2{


    public static void um(){

        Double f = 0;

        Double vp = 1000.00;

        Double tx = 0.053;

        int pm = 10;

        Double juros = 1 + tx;

        f = vp * Math.Pow(juros, pm);

        Console.WriteLine("o valor Futuro é: "+ f);

    }

    public static void dois(){

        Double vp = 3800.00;

        Double tx = 0.0125;

        int pm = 6;

        Double[] ren = new Double[pm];

        for (int i = 0; i < pm; i++) {

            vp = vp * (1 + tx);

            ren[i] = vp;

        }

        for (int i = 0; i < pm; i++){

            Console.WriteLine("Rendimento("+ i + ") = " +ren[i]);

        }        

    }

    public static void tres(){

        Console.WriteLine("Digite o valor presente: ");
        Double vp = Double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o taxa de juros (em decimal): ");
        Double tx = Double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o período (em anos): ");
        int pa = int.Parse(Console.ReadLine() ?? "0");

        Double juros = 1 + tx;

        Double renda = vp * Math.Pow(juros, pa);


        Console.WriteLine("Sua Renda é de: R$"+  renda);
        

    }

    public static void quatro(){

        Console.WriteLine("Digite o valor presente: ");
        Double vp = Double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o taxa de juros (em decimal): ");
        Double tx = Double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o período (em anos): ");
        int pm = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 1; i <= pm; i++)
        {
            double rend = vp * tx;
            vp += rend; 

            
            if (i == 5) { 
            
            Console.WriteLine("Quanto quer resgatar : ");
            Double resg = Double.Parse(Console.ReadLine() ?? "0");

            rend = rend - resg;

            vp -= resg;

            Console.WriteLine("Mês " + i + ": resg de R$ " + resg + ", vp pós-resg: R$ " + vp);

        } else {

            Console.WriteLine("Mês " + i + ": rendimento de R$ " + rend + ", vp acumulado: R$ " + vp);

        }
        }

            Console.WriteLine("\nvp final após " + pm + " meses: R$ " + vp);
    }
    


    

    public static void cinco(){

        Double vp = 0;

        int pa = 2;

        Double vf = 7390.61;

        Console.WriteLine("Digite a taxa de juros ( em decimal): ");
        Double tx = Double.Parse(Console.ReadLine() ?? "0");

        vp = vf / Math.Pow(1 + tx, pa);

        Console.WriteLine("O valor presente é: R$"+ vp);


    }

}