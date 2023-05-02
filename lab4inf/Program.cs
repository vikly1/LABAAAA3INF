using System.Diagnostics;
using System.Linq.Expressions;
Console.WriteLine("Программа для получения факториала и числа фибоначчи.");
Console.WriteLine("Введите число больше нуля");
startt();
void startt()
{
    bool valid = int.TryParse(Console.ReadLine(), out int number);
    if (valid == true && number > 0)
    {
        opers();
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
        startt();
    }
    void opers()
    {
        Console.WriteLine("1 - получение факториала");
        Console.WriteLine("2 - получение числа из ряда Фибоначчи с введённым порядковым номером");
        var selectvalid = Console.ReadKey().Key;
        switch (selectvalid)
        {
            case ConsoleKey.D1:
                Console.WriteLine();
                Console.WriteLine(Factorio(number));
                break;
            case ConsoleKey.D2:
                Console.WriteLine();
                Console.WriteLine(Fibonachi(number));
                break;
            default:
                opers();
                break;
        }
        int Factorio(int number)
        {
            if (number == 1) return 1;
            return number * Factorio(number - 1);
        }
        int Fibonachi(int number)
        {
            if (number == 1 || number == 2) return number - 1;
            return Fibonachi(number - 1) + Fibonachi(number - 2);
        }
    }
}