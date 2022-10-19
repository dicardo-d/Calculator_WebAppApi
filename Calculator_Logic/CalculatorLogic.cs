namespace CalculatorLogic;

    public class Calculator
    {
        public static double Addition(double left, double right)
        {
           return left + right;
    }
        public static double Division(double left, double right)
    {
        if (right != 0)
        {
            return left / right;
        }
        else
        {
            throw new DivideByZeroException();

        }
    }



    }
    





