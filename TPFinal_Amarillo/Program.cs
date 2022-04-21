using System;

namespace TPFinal_Amarillo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números
            //que corta cuando se ingresa un cero. A partir de dichos datos informar:
            //    a. El mayor de los números pares.
            //    b. La cantidad de números impares.
            //    c. El menor de los números primos.
            
            int numero = 0, minPrimo = 0, mayorPar = 0, contarImpar = 0;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            bool bandera = false, bandPar = false;
            while (numero !=0)
            {
                FuncionPrimo(ref numero, ref minPrimo, ref bandera);

                if(numero % 2 == 0){
                    if(bandPar == false){
                        mayorPar = numero;
                        bandPar = true;
                    }
                    if(numero > mayorPar)
                        mayorPar = numero;
                }else
                    contarImpar++;
                
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El menor de los primos es: " + minPrimo);
            Console.WriteLine("El mayorr de los pares es: " + mayorPar);
            Console.WriteLine("la cantidad de impares son: " + contarImpar);

        }
        static void FuncionPrimo(ref int numero, ref int menorPrimo, ref bool bandera)
        {
            int contador = 0;
            
            for (int x = 1; x <= numero; x++)
               {
                   if(numero % x == 0)
                        contador++;
               }
               if(contador == 2)
                    if(bandera == false)
                    {
                        bandera = true;
                        menorPrimo = numero;
                    }
               if(numero < menorPrimo)
                    menorPrimo = numero;
        }
    }
}
