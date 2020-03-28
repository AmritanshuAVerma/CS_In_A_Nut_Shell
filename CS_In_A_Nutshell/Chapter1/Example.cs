using System;

namespace Chapter1
{
    /// <summary>
    /// Example contain all variable type in .net framework
    /// </summary>
    class Example
    {
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Types of variable and inter-convertibility

            String String = new String("Amrit");
            int Integer = 27;
            decimal Decimal = Convert.ToDecimal(27.5);
            Boolean Boolean = true;
            char Character = 'O';
            string @string = "@ ignores the keyword and treat's it like a identifier  ";
            Console.WriteLine("{0} : {1}", "Name", String);
            Console.WriteLine("{0} : {1}", "Age", Integer);
            Console.WriteLine("{0} : {1}", "Precise Age", Decimal);
            Console.WriteLine("{0} : {1}", "Developer", Boolean);
            Console.WriteLine("{0} : {1}+", "Blood Group", Character);
            Console.WriteLine("{0} : {1}", "Using Keyword as Identifier", @string);

            Console.ReadKey();
        }
    }
}
