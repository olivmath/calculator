namespace Calculator
{
    public class Math
    {
        static public float Add(float x, float y)
        {
            return x + y;
        }

        static public float Sub(float x, float y)
        {
            return x - y;
        }

        static public float Mul(float x, float y)
        {
            return x * y;
        }

        static public float Div(float x, float y)
        {
            if (y == 0)
            {
                return int.MaxValue;
            }
            else
            {
                return x / y;
            }
        }

    }
}