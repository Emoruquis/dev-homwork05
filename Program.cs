using System;

namespace dev_homwork05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool cesarTinehambre = true;

            while(cesarTinehambre ){
                Console.WriteLine($"que quieres comer: ");
                var comida = Console.ReadLine();

                if(comida == "ya no quiero"){
                    cesarTinehambre = false;
                }
                else{
                    Console.WriteLine("preparando: " + comida);
                }
            }
            
            


        }
    }
}
