namespace Calculator
{
    public class Prettier
    {
        static public void StartCalculator()
        {
            Console.Clear();
            Div();
            Console.WriteLine("✅ Calculator Started");
            Div();
            Console.WriteLine("Supported Operations: ");
            Menu();
        }

        static void Div()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("#####################");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void Menu()
        {
            Console.WriteLine("sum, sub, mul, div");
            Console.WriteLine("ex: sum 5 5");
            Div();

            string[] _args = Console.ReadLine().Trim().Split(' ');
            (string op, int x, int y) = Utils.ParseArgs(_args);

            switch (op)
            {
                case "sum": Result("+", x, y, Math.Add); break;
                case "sub": Result("-", x, y, Math.Sub); break;
                case "mul": Result("*", x, y, Math.Mul); break;
                case "div": Result("÷", x, y, Math.Div); break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("#####################");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Invalid operation");
                    Console.WriteLine("exit...");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("#####################");
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Environment.Exit(0); break;
            }
        }

        static public void Result(string op, float x, float y, Func<float, float, float> f)
        {
            Console.Clear();
            Div();
            Console.WriteLine($"{x} {op} {y} => {f(x, y)}");
            Div();
            Console.WriteLine();
            Div();
            Menu();
        }
    }
}