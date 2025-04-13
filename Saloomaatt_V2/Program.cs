using Calculator;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Console Calculator: \n\n1. Qo'shish \n2. Ayirish \n3. Ko'paytirish \n4. Bo'lish \n5. Qoldiqli bo'lish");

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

                MathV2.qoldiqliBolish(number1, number2);
                break;
        }
    }
}