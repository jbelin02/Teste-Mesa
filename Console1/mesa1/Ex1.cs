using System;
public class Ex1{

    public static void um(){

        

        int a = 10;

        int b = 20;

        int c = (a + b) / 2;

        c = c - 40;

        

        int[] vetor = new int[7];
        
        vetor[3] = a + b + c;

       

        for(int i = 0; i <= 6; i++){

           Console.Write("Vetor [" + i + "] = " + vetor[i] + " -> "); 

            if(vetor[i] == 5){

                Console.WriteLine("VERDADEIRO");

            }else{

                Console.WriteLine("FALSO");

            }

        }



    }

    public static void dois(){

       

        int a = 2;

        int[] vetor = new int [7];

        while(a < 6){

            vetor[a] = 10 * a;
            a += 1;
        }

        for(int i = 0; i <= 6; i++){

           Console.Write("Vetor [" + i + "] = " + vetor[i] + " -> "); 

            if(i < 6){

                Console.WriteLine("VERDADEIRO");

            }else{

                Console.WriteLine("FALSO");

            }

        }


    }

    public static void tres(){


        int a = 7;

        int b = a - 6;

        int[] vetor = new int [7];

        while(b < a){

            vetor[b] = b + a;  
            b += 2;
        }

        for(int i = 0; i <= 6; i++){

           Console.Write("Vetor [" + i + "] = " + vetor[i] + " -> "); 

            if(vetor[i] < 7){

                Console.WriteLine("VERDADEIRO");

            }else{

                Console.WriteLine("FALSO");

            }

        }




    }
}
 