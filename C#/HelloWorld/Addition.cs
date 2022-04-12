namespace HelloWorld
{
    public class Addition
    {
        public static void Add()
        {
            Console.Write("Please enter first number ");
        // user input is always in string format
        //input1:
            var num1String = Console.ReadLine();
            double num1;
            while (double.TryParse(num1String, out num1) != true)
            {
                Console.Write("Entered value is not a number!!\nPlease enter first number ");
               // goto input1;
               num1String = Console.ReadLine();
            }
            Console.Write("Please enter second number ");
        input2:
            var num2String = Console.ReadLine();
            double num2;

            while (double.TryParse(num2String, out num2) != true)
            {
                Console.Write("Entered value is not a number!!\nPlease enter second number ");
                goto input2;
            }
            Console.WriteLine($"{num1} + {num2} = {num1 + num2} ");
        }
    }
}