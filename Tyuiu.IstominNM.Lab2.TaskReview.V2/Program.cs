
using Tyuiu.IstominNM.Lab2.Review.V2.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Истомин Н. М. | НТм-23-1";
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                               *");
        Console.WriteLine("* Тема: Табулирование функции по методологии разработка через тестирование                *");
        Console.WriteLine("* Задание #1                                                                              *");
        Console.WriteLine("* Вариант #2                                                                              *");
        Console.WriteLine("* Выполнил: Истомин Никита Максимович | НТм-23-1                                          *");
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                *");
        Console.WriteLine("* написать программу, которая выводит таблицу значений функции (произвести табулирование) *");
        Console.WriteLine("* f(x) на заданном диапазоне X1, X2. Произвести проверку деления на ноль.                 *");
        Console.WriteLine("* Значения должны храниться в массиве. Округлить значения до двух знаков после запятой.   *");
        Console.WriteLine("*                                                                                         *");
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                       *");
        Console.WriteLine("*******************************************************************************************");
        int startStep = Convert.ToInt32(Console.ReadLine());
        int endStep = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                              *");
        Console.WriteLine("*******************************************************************************************");
        
        
        double[][] result = ds.GetMassFunction(startStep, endStep);



        // Отступы каждых столбцов (10 первый, 20 второй, по 30 два последних) + 5 символов "|"
        Console.WriteLine(new string('-', 10 + 20 + 3));
        Console.WriteLine("|{0,10}|{1,20}|", "X", "F(x)");
        Console.WriteLine(new string('-', 10 + 20 + 3));

        foreach (double[] element in result)
        {
            Console.WriteLine("|{0,10}|{1,20}|", element[0], element[1]);
        }

        
        Console.WriteLine(new string('-', 10 + 20 + 3));
        // Console.WriteLine(ds.Calc(x, y));
        Console.ReadKey();
    }

}