using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;
            bool val0 = false;
            bool val1 = false;
            bool val2 = false;
            bool val3 = false;
            bool val4 = false;
            bool val5 = false;
            bool testList = false;

            //int index5 = 0;
            List<int> numbers = new List<int>();
            List<int> numbers2 = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                numbers.Add(a);
            }

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            //numbers2.AddRange(numbers);

            Console.WriteLine("index of " + numbers[5]);

            do
            {

                val0 = TestSameNumbers0(numbers);
                val1 = TestSameNumbers1(numbers);
                val2 = TestSameNumbers2(numbers);
                val3 = TestSameNumbers3(numbers);
                val4 = TestSameNumbers4(numbers);
                val5 = TestSameNumbers5(numbers);

                //Console.WriteLine(val0);

                if (val5 == false)
                {
                    f++;
                    numbers.RemoveAt(5);
                    numbers.Insert(5, f);
                    
                }
                else if (val4 == false)
                {
                    e++;
                    numbers.RemoveAt(4);
                    numbers.Insert(4, e);
                }
                else if (val3 == false)
                {
                    d++;
                    numbers.RemoveAt(3);
                    numbers.Insert(3, d);
                }
                else if (val2 == false)
                {
                    c++;
                    numbers.RemoveAt(2);
                    numbers.Insert(2, c);                    
                }
                else if (val1 == false)
                {
                    b++;
                    numbers.RemoveAt(1);
                    numbers.Insert(1, b);                    
                }
                else if (val0 == false)
                {
                    a++;
                    numbers.RemoveAt(0);
                    numbers.Insert(0, a);                    
                }

                if (testList == true)
                {
                    numbers2.Clear();
                    numbers2.AddRange(numbers);
                }

                foreach (int item in numbers)
                {
                    Console.WriteLine("1 list " + item);
                }
                foreach (int item in numbers2)
                {
                    Console.WriteLine("2 list " + item);
                }
                //Console.WriteLine(numbers.IndexOf(5));
                //Console.WriteLine("val 0: " + val0 + "\nval 1: " + val1 + "\nval 2: " + val2 + "\nval 3: " + val3 + "\nval 4: " + val4 + "\nval 5: " + val5);

                //Console.ReadKey();

                //numbers2.AddRange(numbers);

                testList = TestSameLists(numbers, numbers2);

                if (testList == false)
                {
                    Console.WriteLine("listai vienodi");
                }
                else
                {
                    Console.WriteLine("listai skirtingi");
                }
                Console.ReadKey();

            }
            while (val0 == false || val1 == false || val2 == false ||
                   val3 == false || val4 == false || val5 == false ||
                   testList == false);

            Console.WriteLine("val 0: " + val0 + "\nval 1: " + val1 + "\nval 2: " + val2 + "\nval 3: " + val3 + "\nval 4: " + val4 + "\nval 5: " + val5);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            /*
            numbers2.AddRange(numbers);

            bool testList = TestSameLists(numbers, numbers2);

            if (testList == false)
            {
                Console.WriteLine("listai vienodi");
            }
            else
            {
                Console.WriteLine("listai skirtingi");
            }
            */




            Console.ReadKey();

        }

        /*
            for (int i = 0; i < numbers.Count; i++)
            {
                //Console.WriteLine(numbers[i]);
                for (int j = 0; j < numbers.Count; j++)
                {
                    //Console.WriteLine(numbers[j]);
                    if (numbers[i] == numbers[j])
                    {

                    Console.ReadKey();
                    return false;                        
                    }
                }
            }    
        return true;
             }
        */
        private static bool TestSameLists(List<int> numbers, List<int> numbers2)

        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("L1 " + numbers[i]);
                for (int j = 0; j < numbers2.Count; j++)
                {
                    Console.WriteLine("L2: " + numbers2[j]);
                    if (numbers[i] == numbers2[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool TestSameNumbers0(List<int> numbers)
        {
            if (numbers[0] == numbers[5]
             || numbers[0] == numbers[4]
             || numbers[0] == numbers[3]
             || numbers[0] == numbers[2]
             || numbers[0] == numbers[1])
            {
                return false;
            }
            return true;
        }

        private static bool TestSameNumbers1(List<int> numbers)
        {
            if (numbers[1] == numbers[5]
             || numbers[1] == numbers[4]
             || numbers[1] == numbers[3]
             || numbers[1] == numbers[2]
             || numbers[1] == numbers[0])
            {
                return false;
            }
            return true;
        }

        private static bool TestSameNumbers2(List<int> numbers)
        {
            if (numbers[2] == numbers[5]
             || numbers[2] == numbers[4]
             || numbers[2] == numbers[3]
             || numbers[2] == numbers[1]
             || numbers[2] == numbers[0])
            {
                return false;
            }
            return true;
        }

        private static bool TestSameNumbers3(List<int> numbers)
        {
            if (numbers[3] == numbers[5]
             || numbers[3] == numbers[4]
             || numbers[3] == numbers[2]
             || numbers[3] == numbers[1]
             || numbers[3] == numbers[0])
            {
                return false;
            }
            return true;
        }

        private static bool TestSameNumbers4(List<int> numbers)
        {
            if (numbers[4] == numbers[5]
             || numbers[4] == numbers[3]
             || numbers[4] == numbers[2]
             || numbers[4] == numbers[1]
             || numbers[4] == numbers[0])
            {
                return false;
            }
            return true;
        }

        private static bool TestSameNumbers5(List<int> numbers)
        {
            if (numbers[5] == numbers[4]
             || numbers[5] == numbers[3]
             || numbers[5] == numbers[2]
             || numbers[5] == numbers[1]
             || numbers[5] == numbers[0])
            {
                return false;
            }
            return true;
        }
    }
}
