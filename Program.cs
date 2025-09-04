namespace HW4prt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first operand");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Enter second operand");
            string secondInput = Console.ReadLine();
            double firstOperand = 0; // Чесно буду радий коментарам, цей момент не знаю як елігантніше зробити окрім як попереднього оголошення змінних з присвоєнням нулей
            double secondOperand = 0;
            try
            {
                firstOperand = double.Parse(firstInput.Replace(".", ","));
                secondOperand = double.Parse(secondInput.Replace(".", ","));
                Console.WriteLine("Operands has been converted succesfully");

            }
            catch (Exception)
            {
                Console.WriteLine("Enter a numberic values");
            }
            Console.WriteLine("Select an operation \"+\" / \"-\" / \"*\" / \"/\"");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {firstOperand + secondOperand}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {firstOperand-secondOperand}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {firstOperand*secondOperand}");
                    break;
                case "/":
                    if (secondOperand != 0)
                    {
                        Console.WriteLine($"Result: {firstOperand/secondOperand}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cannot devide by zero");
                        break;
                    }
                default:
                    Console.WriteLine("Select an operation from suggested");
                    break ;
            }   
        }
    }
}
