namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g, h;
            Console.WriteLine("Добро подаловать в Counter 1.0!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Эта программа поможет вам подсчитать количество четных и не четных чисел");
            Console.WriteLine("в выбраном вами диапазоне целых положительных чисел");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Настоятельно прошу использовать числа от 0 до  2 147 483 647");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine( "Значение 'до' должно быть меньше значения 'от'");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Для начала работы нажмите любую кнопку");
            Console.ReadKey();
            Console.WriteLine("Введите диапазон чисел");
            Console.WriteLine("от ");
            a = int.Parse(Console.ReadLine());

            if (a<0)
            {


                while (a < 0)
                {
                    Console.WriteLine("Вы ввели отрицательное число, повторите попытку");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("от ");
                    a = int.Parse(Console.ReadLine());
                }

            }




        Console.WriteLine("до ");
            b = int.Parse(Console.ReadLine());
            if (b < a)
            {


                while (b < a)
                {
                    Console.WriteLine("Вы ввели число меньше чем " + a + ", повторите попытку");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("до ");
                    b = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("подождите, пожалуйста, идет подсчет четных и нечетных чисел в диапазоне от " +a + " до" +b);
            d = 0;
            
            
               
         
            while (d < 99)
            {
                d++;
                Console.WriteLine(d + "%");
            }

            g = 0;
            h = 0;

            if (a == 0)
            {
               c =  b - a ;
                e = 1;
            }
            else
            {
                c = b - a+1;
                e = a;
            }
            
           
            while (e <= c)
            {
                f = e % 2;
                e++;
                if (f == 1 || f == -1)
                {
                    g++ ;
                    h = h + 0;
                }
                else
                {
                    h++;
                    g = g + 0;
                }
            }
            Console.WriteLine("100%");
            Console.WriteLine("Подсчет выполнен!");
            Console.WriteLine("Количество четных чисел в диапазоне от " + a + " до " + b + " = " + h);
            Console.WriteLine("Количество не четных чисел в диапазоне от " + a + " до " + b + " = " + g);
            
        }
    }
} 