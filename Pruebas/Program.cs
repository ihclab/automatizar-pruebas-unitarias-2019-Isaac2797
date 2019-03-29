using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Medias medias = new Medias();
            //Actividad 02
            Stopwatch sw = new Stopwatch();
            string save = DateTime.Now.ToString() + "\r\n";
            string[] Casos;
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/Isaac/Documents/automatizar-pruebas-unitarias-2019-Isaac2797/Casos.txt"))
                {
                    
                    string row;

                    while ((row = sr.ReadLine()) != null)
                    {
                        sw.Start();
                        Casos = row.Split(':');
                        foreach (string word in Casos)
                        {
                            Console.WriteLine(word);
                            save += word + ":";
                        }

                        try
                        {
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
                                        save += "\r\n" + "Resultado final " + newresult;
                                        if (newresult == finalresult)
                                        {
                                            Console.WriteLine("Exito", Console.ForegroundColor = ConsoleColor.Green);
                                            save += "\r\n" + "Exito";
                                        }
                                        else
                                        {
                                            Console.WriteLine("Fallo", Console.ForegroundColor = ConsoleColor.Red);
                                            save += "\r\n" + "Exito";
                                        }
                                        Console.ResetColor();
                                        break;

                                    case "mediaGeometrica":
                                        newresult = medias.mediaGeometrica(values);
                                        newresult = Math.Truncate(10000 * newresult) / 10000;
                                        Console.WriteLine("Resultado final: " + newresult);
                                        save += "\r\n" + "Resultado final " + newresult;
                                        if (newresult == finalresult)
                                        {
                                            Console.WriteLine("Exito", Console.ForegroundColor = ConsoleColor.Green);
                                            save += "\r\n" + "Exito";
                                        }
                                        else
                                        {
                                            Console.WriteLine("Fallo", Console.ForegroundColor = ConsoleColor.Red);
                                            save += "\r\n" + "Exito";
                                        }
                                        Console.ResetColor();
                                        break;

                                    case "mediaArmonica":
                                        newresult = Medias.mediaArmonica(values);
                                        newresult = Math.Truncate(10000 * newresult) / 10000;
                                        Console.WriteLine("Resultado final: " + newresult);
                                        save += "\r\n" + "Resultado final " + newresult;
                                        if (newresult == finalresult)
                                        {
                                            Console.WriteLine("Exito", Console.ForegroundColor = ConsoleColor.Green);
                                            save += "\r\n" + "Exito";
                                        }
                                        else
                                        {
                                            Console.WriteLine("Fallo", Console.ForegroundColor = ConsoleColor.Red);
                                            save += "\r\n" + "Exito";
                                        }
                                        Console.ResetColor();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor de entrada es NULL. No valido!");
                                save += "\r\n" + "Valor de entrada es NULL. No valido!";
                            }
                            sw.Stop();
                            Console.WriteLine("Tiempo: " + sw.Elapsed +"\n");
                            save += "\r\n" + "Tiempo de ejecucion: " + sw.Elapsed + "\r\n" + "\r\n";
                            sw.Reset();

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message + "\n");
                        }

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

            using (StreamWriter swriter = new StreamWriter("C:/Users/Isaac/source/repos/Pruebas/GuardarPruebas.txt"))
            {
                swriter.WriteLine(save);
            }
        }
    }
}


