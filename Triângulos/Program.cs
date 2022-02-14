using System;

namespace Triângulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladoA, ladoB, ladoC;
            char teste;
            Console.WriteLine("Classificador de triângulos:");
            do
            {
                do
                {
                    Console.Write("Digite o ladoA:");
                    ladoA = Convert.ToDouble(Console.ReadLine());
                    if (ladoA < 0)
                    {
                        Console.WriteLine("Digite Apenas medidas validas !!!");
                    }
                } while (ladoA < 0);
                do
                {
                    Console.Write("Digite o ladoB:");
                    ladoB = Convert.ToDouble(Console.ReadLine());
                    if (ladoB < 0)
                    {
                        Console.WriteLine("Digite Apenas medidas validas !!!");
                    }
                } while (ladoB < 0);
                do
                {
                    Console.Write("Digite o ladoC:");
                    ladoC = Convert.ToDouble(Console.ReadLine());
                    if (ladoC < 0)
                    {
                        Console.WriteLine("Digite Apenas medidas validas !!!");
                    }
                } while (ladoC < 0);

                if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
                {
                    if (ladoA == ladoB && ladoB == ladoC)
                    {
                        Console.WriteLine("Triângulo equilatero !!!");
                    }
                    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                    {
                        Console.WriteLine("Triângulo isósceles !!!");
                    }
                    else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
                    {
                        Console.WriteLine("Triângulo escaleno !!!");
                    }
                }
                else
                {
                    Console.WriteLine("Esté triângulo não existe !!!");
                }
                do
                {
                    Console.Write("Deseja verificar a classificação de algum triângulo(s/n)?");
                    teste = Convert.ToChar(Console.ReadLine());
                    if(teste != 's' && teste != 'n')
                    {
                        Console.WriteLine("digite apenas s (para continuar) ou n (para sair)");
                    }
                }while(teste != 's' && teste != 'n');
            } while (teste == 's');
        }
    }
}
