using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //pt.rakko.tools ->> ascii 
            //String.Contains Método


            /*string textFile = @"output_file";
            string[] lines = File.ReadAllLines(textFile);
            foreach (string line in line) */
            
             /*Console.WriteLine(line);*/

            Console.WriteLine("Bem-vindo!");
            Console.WriteLine("Para começarmos, digite o seu nome:____________");
            string name = Console.ReadLine();
            Console.Clear(); 
            Console.WriteLine("Olá, " + name + " seja bem-vindo ao game...");
            Console.Clear();
            Console.WriteLine(name + ", para começar a investigar o crime digie (Quero investigar) e para sair digite (Quero sair)..."); 
       


            Console.ReadLine();
        }
    }
}
