using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.");
            int number;
            Random random = new Random(100);
            random.Next();
            for (int i = 0; i < 3; i++)
            {
                number = random.Next(10);
                Console.Write(number);
                Console.Write("  ");
            }
    
            Console.Read();

            Console.Read();

             Console.WriteLine("2.Вывести на экран числа 5, 10 и 21 одно под другим.");
             Console.WriteLine("5");
             Console.WriteLine("10");
             Console.WriteLine("21");


            Console.WriteLine("3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.");
            int centimeters;
            Console.WriteLine("enter count of centimeters");

            centimeters = int.Parse(Console.ReadLine());

            int hundred = 100;

            int meters = centimeters / hundred;
            Console.WriteLine(meters);

            Console.ReadLine();

            Console.WriteLine("4.С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
            int days = 234;
            int daysInWeek = 7;
            int weeks = days / daysInWeek;
            Console.WriteLine(weeks);

            Console.ReadLine();

            Console.WriteLine("5.Дано двузначное число. Найти:");
            Console.WriteLine("enter two - digit number");
            int number2;
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("a.число десятков в нем;");

            int ten = 10;

            int dozensOf = number2 / ten;
            Console.WriteLine(dozensOf);

            Console.WriteLine("b.число единиц в нем;");
            int units = number2 % 10;
            Console.WriteLine(units);

            Console.WriteLine("c.сумму его цифр;");
            int sum = dozensOf + units;
            Console.WriteLine(sum);

            Console.WriteLine("d.произведение его цифр");
            int multi = dozensOf * units;
            Console.WriteLine(multi);

            Console.ReadLine();

            Console.WriteLine("6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:");
            bool A = true;
            bool B = false;
            bool C = false;

            Console.WriteLine("a.А или В; ");
            bool D;
            D = A | B;
            Console.WriteLine(D);

            Console.WriteLine("b.А и В;");
            D = A & B;
            Console.WriteLine(D);

            Console.WriteLine("c.В или С.");
            D = B | C;
            Console.WriteLine(D);

            Console.ReadLine();

            Console.WriteLine("7.Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?");

            int r;
            int s;
            Console.WriteLine("enter radius");
            r=int.Parse(Console.ReadLine());
            Console.WriteLine("enter side");
            s = int.Parse(Console.ReadLine());

            var circleS = Math.PI * r * r;
            var sqareS = s * s;
            if (circleS > sqareS)
            {
                Console.WriteLine("Площадь круга больше");
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше");
            }

            Console.ReadLine();


            Console.WriteLine(" 8.Даны объемы и массы двух тел из разных материалов.Материал какого из тел имеет большую плотность?");
            int V1, V2, m1, m2;
            Console.WriteLine("enter V1, m1");
            V1 = int.Parse(Console.ReadLine());
            m1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter V2, m2");
            V2 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());

            double density1, density2;
            density1 = m1 / V1;           
            density2 = m2 / V2;

            if (density1 > density2)
            {
                Console.WriteLine("Density1 is bigger");
                Console.WriteLine(density1);
            }
            else
            {
                Console.WriteLine("Density2 is bigger");
                Console.WriteLine(density2);
            }

            Console.ReadLine();


            Console.WriteLine("9. Известны сопротивления двух несоединенных " +
                "друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?");

            int U1, U2, R1, R2;
            Console.WriteLine("enter U1, R1");
            U1 = int.Parse(Console.ReadLine());
            R1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter U2, R2");
            U2 = int.Parse(Console.ReadLine());
            R2 = int.Parse(Console.ReadLine());

            double I1 ,I2;
            I1 = U1 / R1;
            I2 = U2 / R2;

            if (I1 < I2)
            {
                Console.WriteLine("I1 is lower");
                Console.WriteLine(I1);
            }
            else
            {
                Console.WriteLine("I2 is lower");
                Console.WriteLine(I2);
            }

            Console.ReadLine();

            Console.WriteLine("10.Напечатать столбиком");
            Console.WriteLine("a.все целые числа от 20 до 35;");

            for(int i = 20; i < 35; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            Console.WriteLine("b.квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);");
            int number5;
            number5 = int.Parse(Console.ReadLine());
            Console.ReadLine();
            for (int i = 10; i < number5+1; i++)
            {
                Console.WriteLine(i*i);
            }
            Console.ReadLine();

            Console.WriteLine("c.третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);");
            int number6;
            number6 = int.Parse(Console.ReadLine());

            for (int i = number6; i < 51; i++)
            {
                Console.WriteLine(i * i * i);
            }
            Console.ReadLine();

            Console.WriteLine("d.все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).");
            int number3;
            int number4;
            number3 = int.Parse(Console.ReadLine());
            number4 = int.Parse(Console.ReadLine());

            for (int i = number3; i < number4; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }


    }
}

