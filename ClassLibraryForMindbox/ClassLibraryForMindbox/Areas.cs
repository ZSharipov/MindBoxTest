using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForMindbox
{
    public class Areas
    {       
        public static string AreaCalculation(params double[] values)
        {
            // switch удобнее чем if если фигур будут много
            switch (values.Length)
            {
                case 3:
                    return AreaTriangle(values);                    
                case 1:
                    return AreaCircle(values[0]);                    
                default:
                    return ("Unknown figure");                    
            }
           
        }

        public static string AreaTriangle(double[] values)
        {
            // Формула Герона S=√p(p−a)(p−b)(p−c), p=1/2(a+b+c) 
            double a = values[0],
                b = values[1],
                c = values[2];
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            //Проверка на то, является ли треугольник прямоугольным a²+b²=c²
            //Находим гипотенузу т.е. самую длиную сторону

            double max = 0;
            int index = 0; // индекс максимального значение внутри values
            for (int i = 0; i < 3; i++)
            {
                if (max < values[i])
                {
                    max = values[i];
                    index = i;
                }
            }

            // (c²==a²+b²) c=values[index]. нужно найти сумму квадратов катетов т.е. a²+b²=?

            double katets = 0;
            for (int i = 0; i < 3; i++)
            {
                if (i == index)
                {
                    continue; //пропускаем гипотенузу
                }

                katets += Math.Pow(values[i], 2);
            }

            bool IsRightTriangle = (Math.Pow(values[index], 2) == katets);

            return ("Triangle, S=" + s + ", IsRightTriangle=" + IsRightTriangle);

        }
        public static string AreaCircle(double r)
        {
            // S=πr²   
            double s = Math.PI * Math.Pow(r, 2); //либо 3.14*r*r;
            return ("Circle, S=" + s);
        }

    }
}
