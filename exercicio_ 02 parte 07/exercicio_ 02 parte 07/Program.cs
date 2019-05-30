using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio__02_parte_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int media;

            Console.WriteLine("Digite a primeira nota. ");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota. ");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota. ");

            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota. ");

            d = int.Parse(Console.ReadLine());

            media = (a + b + c + d) / 4;

            if (media < 6)
            {

                Console.WriteLine("Reprovado!");
            }
            else
            {
                Console.WriteLine("Aprovado!");
            }
            Console.ReadKey();
        }
            }
                }

                    
                
           
               
         

          

          


                   
                      

                       
               
            
          
            

        
    