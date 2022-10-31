namespace Calculator
{
    class Utils
    {
        public enum Op
        {
            Sum, Sub, Mul, Div
        }
        static public Tuple<string, int, int> ParseArgs(string[] args)
        {
            if (args.Length < 3)
            {
                return Tuple.Create("not", 0, 0);
            }
            else if (
                args[0] is not null &&
                args[1] is not null &&
                args[2] is not null
                )
            {
                return Tuple.Create(
                    args[0],
                    int.Parse(args[1]),
                    int.Parse(args[2])
                );
            }
            else
            {
                return Tuple.Create("not", 0, 0);
            }
        }
    }
}