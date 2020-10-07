using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block_1
{

    static class Ex
    {
        static private long Factor(int number){
            if (number <= 1)
                return 1;
            long result = 1;
            for (int i = 2; i <= number; i++)
                result *= i;
            return result;
        }

        static private double Power(double x, double pow)
        {
            double result = 1;
            while(pow != 0)
            {
                result = (pow > 0) ? result * x : result / x;
                pow = (pow > 0) ? pow - 1 : pow + 1;
            }
            return result;
        }

        static public double CalcSumClasic(double x, double accuracy)
        {
            if (x == 0) return 1;
            bool minus = false;

            if (x < 0)
            {
                minus = true;
                x *= -1;
            }

            double result = 1 + x;
            double element;

            int i = 2;
            do
            {
                element = Power(x, i) / Factor(i);
                result += element;
                i++;
            } while (element > accuracy);

            if (minus) result = 1 / result;

            return result;
        }

        static public double CalcSumReq(double x, double accuracy)
        {
            if (x == 0) return 1;
            bool minus = false;

            if (x < 0)
            {
                minus = true;
                x *= -1;
            }

            double result = 1 + x;
            double element = x;
            double element1;

            int i = 1;
            do
            {
                element1 = element * x / (i + 1);
                result += element1;
                element = element1;
                i++;
            } while (element > accuracy);

            if (minus) result = 1 / result;

            return result;
        }
    }
}
