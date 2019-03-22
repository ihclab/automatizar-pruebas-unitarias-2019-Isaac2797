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
            Medias medias = new Medias();

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

                        double newresult = 0;
                        double finalresult = Convert.ToDouble(Casos[3]);
                        if (Casos[2] != "NULL")
                        {
                            string[] numbers = Casos[2].Split(' ');
                            int[] values = new int[numbers.Length];
                            int inc = 0;

                            foreach (string number in numbers)
                            {
                                values[inc] = Convert.ToInt32(number);
                                inc++;
                            }

                            switch (Casos[1])
                            {
                                case "mediaAritmetica":
                                    newresult = Medias.mediaAritmetica(values);
                                    newresult = Math.Truncate(10000 * newresult) / 10000;
                                    Console.WriteLine("Resultado final: " + newresult);
                                    if (newresult == finalresult)
                                    {
                                        Console.WriteLine("Exito" + "\n");
                                    }
                                    else
                                        Console.WriteLine("Fallo" + "\n");
                                    break;

                                case "mediaGeometrica":

                                    newresult = medias.mediaGeometrica(values);
                                    newresult = Math.Truncate(10000 * newresult) / 10000;
                                    Console.WriteLine("Resultado final: " + newresult);
                                    if (newresult == finalresult)
                                    {
                                        Console.WriteLine("Exito" + "\n");
                                    }
                                    else
                                        Console.WriteLine("Fallo" + "\n");
                                    break;

                                case "mediaArmonica":
                                    newresult = Medias.mediaArmonica(values);
                                    newresult = Math.Truncate(10000 * newresult) / 10000;
                                    Console.WriteLine("Resultado final: " + newresult);
                                    if (newresult == finalresult)
                                    {
                                        Console.WriteLine("Exito" + "\n");
                                    }
                                    else
                                        Console.WriteLine("Fallo" + "\n");
                                    break;
                            }
                        }
                        else
                            Console.WriteLine("Valor de entrada es NULL. No valido!");

                        Console.ReadKey();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
    }
}
