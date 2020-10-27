using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace project_test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 11; a > 0; a -= 2)
            {
                Console.Write($"a는 {a} ");
                for (int b = 0; b < a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
*/

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            /*
            CreditCard myCredit;
            myCredit.name = "jiyang";
            myCredit.number = 12345678;
            myCredit.validThru = 11223344;
            myCredit.cvc = 123;

            var card = ("name", 12341241, 0202, 123);

            int a = new int();
            a = 100;
            var name = "joe";
            Console.WriteLine($"name : {name.GetType()}");
            var age = 23;
            Console.WriteLine($"age : {age.GetType()}");

            Console.WriteLine(a.ToString($"{a.GetType()} a = {a}"));

            CreditCard newCredit = new CreditCard("MJY", 12121212, 123123, 321);
            newCredit = myCredit;
            newCredit.name = "JY";
            Console.WriteLine(newCredit.ToString());



            Console.WriteLine(myCredit.ToString());
            Console.ReadLine();
            */

            int[,] score = new int[2, 4] { { 100, 80, 75, 88 }, { 90, 50, 55, 65 } };
            int i = 0;
            int sum = 0;
            for (i = 0; i < score.GetLength(0); i++)
            {
                for (int j = 0; j < score.GetLength(1); j++)
                {
                    Console.WriteLine($"score_{i},{j} : {score[i, j]}");
                    sum += score[i, j];
                }
            }
            Console.WriteLine($"Average score : {sum / score.Length}");

        }


    }
    struct CreditCard
    {
        public string name;
        public long number;
        public int validThru;
        public int cvc;

        public CreditCard(String name, long number, int validThru, int cvc)
        {
            this.name = name;
            this.number = number;
            this.validThru = validThru;
            this.cvc = cvc;
        }

        public override string ToString()
        {
            return string.Format($"{name}, {number}, {validThru}, {cvc}");
        }
    }
}