using System;
using System.Linq;
using System.Threading;

namespace _3.Gun_ODEV1_Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add2(20, 10);
            var result = Add2(20, 10);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3( out number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1); //number1 Hala 20. Ama result 2 de number 1=30 olur number1+number2=150

            Console.WriteLine(result);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4,9));
            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();

        }

        static void Add()
        {
            //DON'T REPEAD YOURSELF (kendini tekrarlama).
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 30)    //number2=30 Eğer number 2 verilmezse 30 alır.
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3( out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers) //Params = istediğin kadar parametre gönderebilirsin.
        {
            return numbers.Sum();  // SUM tüm sayıları topla.
        }
    }
}
