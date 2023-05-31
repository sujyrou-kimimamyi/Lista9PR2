using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;

            Console.WriteLine("Digite qual exercício você deseja verificar. ");
            c = int.Parse(Console.ReadLine());
            
            switch(c)
            {
                case 1:
                    int[] vet;

                    Console.WriteLine("Entre com o tamanho");
                    int t = int.Parse(Console.ReadLine());
                    vet = new int[t];

                    Random rand = new Random();

                    float soma = 0;
                    float m = 0;

                    for (int i = 0; i < t; i++)
                    {
                        vet[i] = rand.Next(5, 70);
                        soma = soma + vet[i];
                        Console.WriteLine("O valor do índice " + i + " é igual a " + vet[i]);
                    }

                    m = soma / (float)t;

                    Console.WriteLine("A média entre os valores dos índices do vetor é igual a " + m);

                    Console.ReadKey();
                    break;
                case 2:
                    int[] vet2;

                    Console.WriteLine("Entre com o tamanho");
                    int t2 = int.Parse(Console.ReadLine());
                    vet2 = new int[t2];

                    Random rand2 = new Random();

                    float soma2 = 0;
                    float somai2 = 0;
                   

                    for (int i2 = 0; i2 < t2; i2++)
                    {
                        vet2[i2] = rand2.Next(5, 70);
                        
                        if(soma2 % 2 == 0)
                        {
                            soma2 = soma2 + vet2[i2];
                        }
                        else
                        {
                            somai2 = somai2 + vet2[i2];
                        }

                        Console.WriteLine("O valor do índice " + i2 + " é igual a " + vet2[i2]);
                    }

                    

                    Console.WriteLine("A soma entre os valores pares é igual a " + soma2 + " e a dos ímpares é " + somai2);

                    Console.ReadKey();
                    break;
                case 3:
                    {
                        int[] vet3;

                        Console.WriteLine("Digite o tamanho do vetor. ");
                        int t3 = int.Parse(Console.ReadLine());

                        vet3 = new int[t3];
                        Random rand3 = new Random();

                        for (int i3 = 0; i3 > t3; i3++)
                        {
                            vet3[i3] = rand3.Next(5, 70);
                        }
                    }
                    break;
                case 4:
                    {
                        int[] vet4;

                        Console.WriteLine("Digite o tamanho do vetor. ");
                        int t4 = int.Parse(Console.ReadLine());

                        vet4 = new int[t4];
                        Random rand4 = new Random();

                        float s4 = 0;
                        float m4 = 0;

                        for (int i4 = 0; i4 > t4; i4++)
                        {
                            vet4[i4] = rand4.Next(5, 70);
                            Console.WriteLine("O valor do índice " + i4 + " é igual a " + vet4[i4]);

                            if ((vet4[i4] % 3 == 0) && (vet4[i4] % 5 == 0))
                            {
                                s4 = s4 + vet4[i4];
                            }
                            m4 = s4 / (float)t4;

                            Console.WriteLine("A média entre os valores divisíveis por 3 e 5 é igual a " + m4);

                    }
                        break;

            }
        }
    }
}
