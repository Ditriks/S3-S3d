Console.Write("Введите четверть: ");
int i = Convert.ToInt32(Console.ReadLine());


    if (i == 1)
    {
        Console.Write ("x > 0, y >0");
    }
    if (i == 2)
    {
        Console.Write ("x < 0, y >0");
    }
    if (i == 3)
    {
        Console.Write ("x < 0, y < 0");
    }
    if (i == 4)
    {
        Console.Write ("x > 0, y < 0");
    }
 else{
    Console.WriteLine ("Неть! Можно только 1, 2, 3, 4");
 }

