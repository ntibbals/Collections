using System;
using System.Collections.Generic;

namespace LInqDemo
{
    /// <summary>
    ///  has return type of void and accepts not agruments
    /// </summary>
    delegate void MyDelegate(); ///delegate allows us to send parameters as code
                                ///under hood is creating a class MyDelegate
                                ///
    delegate bool NumberDelegate(int n);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDelegate del = new MyDelegate(Greeting); ///instantiating new del object, referencing code into greeting which is equal to console.writeline
            //or
            MyDelegate del1 = Greeting;

            int[] myNumbers = { 2, 3, 4, 5, 6, 7, 8 };

            IEnumerable<int> numms = GetAllEvenNumber(myNumbers);
            IEnumerable<int> odds = GetAllOddNumber(myNumbers);
            foreach (var item in numms)
            {
                Console.WriteLine(item);
            }
            foreach (var item in odds)
            {
                Console.WriteLine(item);
            }

            del();//
            del.Invoke();
            PassAdDelage(del);
        }

        static void Greeting()
        {
            Console.WriteLine("hello class");
        }

        static void PassAdDelage(MyDelegate delly)
        {
            delly();
        }

        static IEnumerable<int> GetAllEvenNumber(IEnumerable<int> numbers)
        {
            foreach (int item in numbers)
            {
                if(item % 2 == 0)
                {
                    yield return item;
                }
            }
        }
        static IEnumerable<int> GetAllOddNumber(IEnumerable<int> numbers)
        {
            foreach (int item in numbers)
            {
                if (item % 2 != 0)
                {
                    yield return item;
                }
            }
        }
        static IEnumerable<int> GetAllFive(IEnumerable<int> numbers)
        {
            foreach (int item in numbers)
            {
                if (item % 5 == 0)
                {
                    yield return item;
                }
            }
        }
        static bool GetAllEvens(int n) { return n % 2 == 0; }
        static bool GetAllOdds(int n) { return n % 2 != 0; }
        static bool GetAllFiv(int n) { return n % 5 == 0; }
    }
}
