using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Casos;
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/Isaac/Documents/automatizar-pruebas-unitarias-2019-Isaac2797/Casos.txt"))
                {
                    string row;

                    while ((row = sr.ReadLine()) != null)
                    {
                        Casos = row.Split(':');
                        foreach (string word in Casos)
                            Console.WriteLine(word);
                    }
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
