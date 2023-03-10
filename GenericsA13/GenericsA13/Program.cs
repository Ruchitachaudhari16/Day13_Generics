namespace GenericsA13

    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Find maximum  number among 3 numbers ");
                //Maximum number between three integer values 
                //It will return first maximum value
                int maxnumber = CheckMaximumNumber.MaximumIntegerNumber(95, 20, 30);
                Console.WriteLine("Maximum integer number is :" + maxnumber);

                //It will return Second maximum value 
                int maxnumber1 = CheckMaximumNumber.MaximumIntegerNumber(20, 95, 30);
                Console.WriteLine("Maximum integer number is:" + maxnumber1);

                //It will return Third maximum value
                int maxnumber2 = CheckMaximumNumber.MaximumIntegerNumber(30, 20, 95);
                Console.WriteLine("Maximum integer number is:" + maxnumber2);

                //It will return First maximum float value
                float maxno = CheckMaximumNumber.MaximumFloat(2.9f, 1.8f, 2.3f);
                Console.WriteLine("Maximum float number is" + maxno);

                //It will return Second maximum float value
                float maxno1 = CheckMaximumNumber.MaximumFloat(1.8f, 2.9f, 2.3f);
                Console.WriteLine("Maximum float number is:" + maxno1);

                //It will return Third maximum float value
                float maxno2 = CheckMaximumNumber.MaximumFloat(1.8f, 2.3f, 2.9f);
                Console.WriteLine("Maximum float number is:" + maxno2);

            }
        }
    }
