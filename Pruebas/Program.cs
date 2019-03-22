﻿using System;
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
                        double finalresult = Convert.ToDouble(Casos[3]);
                        string[] numbers = Casos[2].Split(' ');
                        int[] values = new int[numbers.Length];
                        int inc = 0;
                        foreach(string number in numbers)
                        {
                            values[inc] = Convert.ToInt32(number);
                            inc++;
                        }

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
