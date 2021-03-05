using System;

class Codigo5
{
   static void Main()
   {
        Random Dado = new Random();

        int Jogada1 = Dado.Next(1, 7);
        int Jogada2 = Dado.Next(1, 7);
        int Jogada3 = Dado.Next(1, 7);

        int total = Jogada1 + Jogada2 + Jogada3;

        Console.WriteLine("Jogada do dado: {0} + {1} + {2} = {3}",Jogada1,Jogada2,Jogada3,total);

        if ((Jogada1 == Jogada2) || (Jogada2 == Jogada3) || (Jogada1 == Jogada3))
        {
            if ((Jogada1 == Jogada2) && (Jogada2 == Jogada3))
            {
                Console.WriteLine("\nVocê jogou três vezes o mesmo número.  +6 bônus no total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("\nVocê jogou duas vezes o mesmo número.  +2 bônus no total!");
                total += 2;
            }
        }

        if (total >= 16)
        {
            Console.WriteLine("\nCom um total de {0} pontos, você ganhou um novo carro!",total);
            Console.ReadKey();
        }
        else if (total >= 10)
        {
            Console.WriteLine("\nCom um total de {0} pontos, você ganhou um novo computador!",total);
            Console.ReadKey();
        }
        else if (total == 7)
        {
            Console.WriteLine("\nCom um total de {0} pontos, você ganhou uma viagem para dois!",total);
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nCom um total de {0} pontos, você ganhou uma caneta!",total);
            Console.ReadKey();
        }
   }
}
