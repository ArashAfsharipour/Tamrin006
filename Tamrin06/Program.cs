
using System;

class Program
{
    static void Main()
    {
        Console.Write("Yek adad vared konid: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Adad mosbat ast.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Adad manfi ast.");
        }
        else
        {
            Console.WriteLine("Adad sefr ast.");
        }
    }
}
