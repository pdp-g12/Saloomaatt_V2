﻿using Saloomaatt_V2.Samandar;
using Saloomaatt_V2.wwLinux;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Console Calculator: \n\n1. Qo'shish \n2. Ayirish \n3. Ko'paytirish \n4. Bo'lish \n5. Qoldiqli bo'lish \n6. Faktorial");

        int select = Convert.ToInt32(Console.ReadLine());

        switch (select)
        {
            case 1:
                //code
                break;
            case 2:
                // code
                break;
            case 3:
                //code
                break;
            case 4:
                // code
                break;
            case 5:
                Console.Write("1- Son kiritin! - ");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2- Son kiritin! - ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                QoldiqliBolish.qoldiqliBolish(number1, number2);
                break;
            case 6:
                Console.Write("Butun son kiriting : ");
                int son = Convert.ToInt32(Console.ReadLine());
                int faktorial = Faktorial.Faktoriall(son);
                Console.WriteLine("Berilgan sonning faktoriali : " + faktorial);
                break;
                default: Console.WriteLine("Bunday amal yo'q!"); break;
        }
    }
}