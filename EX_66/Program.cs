﻿using System;

class Program
{
    static void Main(string[] args)

    {
        int n, m, s = 0;
        Console.Write("Введи значение от: ");
        n = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введи значение до: ");
        m = Convert.ToInt16(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 1 == 0)
                s = s + i ;  


}
        Console.WriteLine("Сумма: " + s);
    }
}
