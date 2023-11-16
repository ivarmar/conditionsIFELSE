namespace conditionsIFELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var oppgave1Result = Class1.TwoNumbers();
            Console.WriteLine(oppgave1Result);

            // oppgave 2
            bool oppgave2Result = Class1.TimesTwo();
            Console.WriteLine(oppgave2Result);

            //oppgave 3
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            var oppgave3Result = Class1.TestingInt(number1, number2);
            Console.Write(oppgave3Result);


        }
    }
}

