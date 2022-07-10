/*
Задача 15: Напишите программу, которая принимает на 
вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
*/



void Zadacha15()
{
    Console.Write("Введите число: ");
    int dd = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите месяц: ");
    int mm = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите год: ");
    int yy = Convert.ToInt32(Console.ReadLine());

    // Проверка высокосный год или нет
    bool vis(int y)
    {
        if ((yy % 4 == 0) && (yy % 100 != 0) || (yy % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Проверка, чтобы день, месяц, год были >0 и лежали в промежутке от 1 до 31. Для каждого месяца свой промежуток
    bool date = false;
    if ((dd > 0) && (mm > 0) && (yy > 0))
    {
        if ((mm == 1 || mm == 3 || mm == 5 || mm == 7 || mm == 8 || mm == 10 || mm == 12) && (dd <= 31)) { date = true; }
        if ((mm == 4 || mm == 6 || mm == 9 || mm == 11) && (dd <= 30)) { date = true; }
        if ((mm == 2) && (vis(yy)) && (dd <= 29)) { date = true; }
        if ((mm == 2) && (!vis(yy)) && (dd <= 28)) { date = true; }
    }

    // Добавляет 0, если число меньше 10
    string format(int text)
    {
        string result = Convert.ToString(text);
        if ((text > 0) && (text < 10))
        {
            result = 0 + result;
        }
        return result;
    }

    // Если дата валидна, то находим код дня недели и выводим название
    int b = -1;
    if (date == true)
    {
        Console.WriteLine("Введена правильная (валидная) дата");
        b = (weekday((short)yy, (byte)mm, (byte)dd));

        Console.Write($"{format(dd)}.{format(mm)}.{yy} это ");
        WeekString(b);
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Вы ввели неправильную (невалидную) дату");
    }

    static byte weekday(short year, byte month, byte day)
    {
        if (month < 3)
        {
            --year;
            month += 10;
        }
        else
            month -= 2;
        return (byte)(((short)day + 31 * (short)month / 12 + year + year / 4 - year / 100 + year / 400) % 7);
    }


    void WeekString(int code)
    {
        switch (code)
        {
            case 1:
                Console.Write("понедельник (рабочий день)");
                break;
            case 2:
                Console.Write("вторник (рабочий день)");
                break;
            case 3:
                Console.Write("среда (рабочий день)");
                break;
            case 4:
                Console.Write("четверг (рабочий день)");
                break;
            case 5:
                Console.Write("пятница (рабочий день)");
                break;
            case 6:
                Console.Write("суббота (выходной день)");
                break;
            case 0:
                Console.Write("воскресенье (выходной день)");
                break;

            default:
                Console.Write("Ошибка!");
                break;
        }
    }

}

Zadacha15();