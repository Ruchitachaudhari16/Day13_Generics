namespace GenericsA13

    {
        internal class Program
        {
        static void Main(string[] args)
        {
            //UC4 Extend the max method to take more than the 3 parametres.
            //integer  values
            int[] intArray = { 102,98,15,76,45,37 };
            GenericsMaximum<int> generic = new GenericsMaximum<int>(intArray);
            generic.PrintValue();

            //double values
            double[] doubleArray = { 23.5,70.5,15.5,90.5,16.5,65.5  };
            GenericsMaximum<double> genericsDouble = new GenericsMaximum<double>(doubleArray);
            genericsDouble.PrintValue();

            //string values
            string[] stringArray = { "abc", "def", "ghj", "mko", "zsd" };
            GenericsMaximum<string> genericString = new GenericsMaximum<string>(stringArray);
            genericString.PrintValue();
        }

        }
    }
    
