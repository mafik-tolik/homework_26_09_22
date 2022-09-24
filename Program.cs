Console.Clear();

// Ex19();
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Ex21();
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Ex19()
{
    Console.WriteLine("Введите целое пятизначное число:");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 10000 && number < 99999)
    {
        int tens_thousands = number / 10000;
        int thousands = number / 1000 % 10;
        int hundreds = number / 100 % 10;
        int tens = number / 10 % 10;
        int ones = number % 10;

        if (tens_thousands == ones && thousands == tens)
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }

        else
        {
            Console.WriteLine($"Число {number} НЕ является палиндромом");
        }
    }

    else
    {
        Console.WriteLine("Введен неверный номер");
    }
}

void Ex21()
{

    int input_coordinates(int x, int y, int z)
    {
        Console.Write("x:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("y:");
        y = Convert.ToInt32(Console.ReadLine());
        Console.Write("z:");
        z = Convert.ToInt32(Console.ReadLine());
        return Console.WriteLine(y, z);
    }

    int x1 = 0, y1 = 0, z1 = 0;
    int x2 = 0, y2 = 0, z2 = 0;

    Console.WriteLine("Введите координаты точки A:");
    input_coordinates(x1, y1, z1);

    Console.WriteLine("Введите координаты точки B:");
    input_coordinates(x2, y2, z2);

}
