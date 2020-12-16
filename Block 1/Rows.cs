using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFunctions;
using Math = MyFunctions.Math;

namespace Block_1
{

    static class Block1
    {

        static public double EPowXClasic(double x, double accuracy)
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
                element = Math.Pow(x, i) / Math.Factor(i);
                result += element;
                i++;
            } while (Math.Abs(element) > accuracy);

            if (minus) result = 1 / result;

            return result;
        }

        static public double EPowXReq(double x, double accuracy)
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
            } while (Math.Abs(element) > accuracy);

            if (minus) result = 1 / result;

            return result;
        }

        static public double Sin(double x, double accuracy)
        {
            while (x >= 2 * Math.PI) x -= 2 * Math.PI;
            double result = x;
            double element = x;
            double element1;

            int i = 0;
            do
            {
                element1 = (-1) * element * Math.Pow(x, 2) / ((2 * i + 2) * (2 * i + 3));
                result += element1;
                element = element1;
                i++;
            } while (Math.Abs(element) > accuracy);

            return result;
        }

        static public double Ln(double arg, double accuracy)
        {
            if (arg == 0) return double.NegativeInfinity;
            if (arg < 0) return double.NaN;
            if (arg > 2)
            {
                int count = 0;
                while(arg > 2)
                {
                    arg /= 2;
                    count++;
                }
                return count * Ln(2, accuracy) + Ln(arg, accuracy);
            }

            double x = arg - 1;
            double element = x;
            double element1;
            double result = x;

            int i = 1;
            accuracy /= 10;

            while (Math.Abs(element) > accuracy)
            {
                element1 = - element * (x * i / (i + 1));
                result += element1;
                element = element1;
                i++;
                if (double.IsNaN(result))
                    break;
            }

            return result;
        }
    }
}
