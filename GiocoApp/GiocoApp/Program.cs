using System;

namespace GiocoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gioco dei numeri ");
            Random num = new Random();
            int n = num.Next(1,100);
            int numero=0;
            int c = 0;
            
            while (numero != n )
            {
                Console.WriteLine("Inserisci numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > n)
                {
                    Console.WriteLine("Il numero inserito è troppo alto");
                }          

                else if(numero < n)
                {
                    Console.WriteLine("Il numero inserito è troppo basso ");
                }

                c++;

            }
                Console.WriteLine("Hai indovinato il numero!");


           
        }
    }
}
