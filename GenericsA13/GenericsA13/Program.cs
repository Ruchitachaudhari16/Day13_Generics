namespace GenericsA13

    {
        internal class Program
        {
            static void Main(string[] args)
            {
            //UC1 Maximum integer number
            Console.WriteLine("Find maximum  number among 3 integer numbers ");
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
            Console.WriteLine("*****************************************************************");

            //UC2 Maximum float Value
            //It will return First maximum float value
            Console.WriteLine("Find maxmium number among 3 float numbers");
            float maxno = CheckMaximumNumber.MaximumFloat(2.9f, 1.8f, 2.3f);
            Console.WriteLine("Maximum float number is" + maxno);

            //It will return Second maximum float value
            float maxno1 = CheckMaximumNumber.MaximumFloat(1.8f, 2.9f, 2.3f);
            Console.WriteLine("Maximum float number is:" + maxno1);
            
            //It will return Third maximum float value
            float maxno2 = CheckMaximumNumber.MaximumFloat(1.8f, 2.3f, 2.9f);
            Console.WriteLine("Maximum float number is:" + maxno2);
            Console.WriteLine("*****************************************************************");

            //UC3 Maximum String 

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
