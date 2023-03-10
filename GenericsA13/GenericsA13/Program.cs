namespace GenericsA13

    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Find maximum  number among 3 float Values ");
                //Maximum number between three float values 
               //It will return First maximum float value
                float maxno = CheckMaximumNumber.MaximumFloat(20.9f, 1.8f, 20.3f);
                Console.WriteLine("Maximum float number is" + maxno);

                //It will return Second maximum float value
                float maxno1 = CheckMaximumNumber.MaximumFloat(1.8f, 20.9f, 20.3f);
                Console.WriteLine("Maximum float number is:" + maxno1);

                //It will return Third maximum float value
                float maxno2 = CheckMaximumNumber.MaximumFloat(1.8f, 20.3f, 20.9f);
                Console.WriteLine("Maximum float number is:" + maxno2);

            }
        }
    }
