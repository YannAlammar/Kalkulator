using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi calculator";
            int a = 10; //declerasi variabel a, dengan nilain awal 10;
            int b = 6; //declerasi variabel b, dengan nilai awal 6;
             
            /*Console.Write("inputan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // Proses Casting 

            Console.Write("inputan nilai b = ");
            int b = int.Convert.ToInt32(Console.ReadLine()); // Proses Casting 

            Console.WriteLine();
            */

            Console.WriteLine("Hasil Penembahan" + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan (0) - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalihan (0) * {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Pembagian (0) / {1} = {2}", a, b, Pengurangan(a, b));

            Console.WriteLine("\nTekan sembarang untuk key keluar");
            Console.ReadKey();


            Console.WriteLine("Pilih Menu Calculator");
            Console.WriteLine("\n1. penembahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalihan");
            Console.WriteLine("4. Pembagian");

          

            Console.WriteLine("inputkan momor menu [1...4 ");
            int menu = int.Parsse(Console)

            if (x == 1)
            {

            }


        }


        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a ,int b)
        {
            return a - b;

        }
        static int Perkalihan(int a , int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    
    
    } 




}
