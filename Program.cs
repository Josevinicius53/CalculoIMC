using System;

namespace novo
{
    class Program
    {
    
        static void Main(string[] args)
        {
            float peso, altura, imc;

            Console.WriteLine("Informe seu Nome:");
             string nome = Console.ReadLine();

             Console.WriteLine("Insira seu peso");
             peso = float.Parse(Console.ReadLine());

             Console.WriteLine("Insira sua Altura: ");
              altura = float.Parse(Console.ReadLine());
              
              imc = peso / (altura * altura);

              if (imc < 18.5)
              {
              Console.WriteLine("Seu IMC é "+ imc + "Abaixo peso");
              }
              else if ( imc < 25)
              {
              Console.WriteLine(" Seu IMC é "+ imc + "Peso Normal ");
              }
            else if (imc < 30 )
              {
              Console.WriteLine("Seu IMC é " + imc + "Sobre peso");
              }

            else if ( imc > 30)  
            {
                Console.WriteLine(" Seu IMC é: "+ imc + "Obesidade" );
            }      


        




        }
    }
}
