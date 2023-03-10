namespace GenericsA13

    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Find maximum  string among 3 string Values ");

            //It will return maximum string value among 3 Strings.
            string maxstring = CheckMaximumNumber.MaximunStringNumber("Peach","Apple","Banana");
                Console.WriteLine("Maximum string is"+maxstring);

            string maxstring1 = CheckMaximumNumber.MaximunStringNumber("Apple","Peach","Banana");
            Console.WriteLine("Maximum string is" + maxstring1);


            string maxstring2 = CheckMaximumNumber.MaximunStringNumber("Banana","Apple","Peach");
            Console.WriteLine("Maximum string is" + maxstring2);

        }
    }
    }
