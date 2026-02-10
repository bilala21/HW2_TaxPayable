

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter taxable income: ");

        try
        {
            decimal income = decimal.Parse(Console.ReadLine() ?? "");
            decimal tax;

            if (income < 1.00m)
            {
                tax = 0.00m;
            }
            else if (income <= 4461.99m)
            {
                tax = 0.00m;
            }
            else if (income <= 17893.99m)
            {
                tax = 0.00m + 0.30m * (income - 4462.00m);
            }
            else if (income <= 29499.99m)
            {
                tax = 4119.00m + 0.35m * (income - 17894.00m);
            }
            else if (income <= 45787.99m)
            {
                tax = 8656.00m + 0.46m * (income - 29500.00m);
            }
            else
            {
                tax = 11179.00m + 0.60m * (income - 45788.00m);
            }

            Console.WriteLine($"Tax payable: {tax:C}");
        }
        catch
        {
            Console.WriteLine("Invalid input. Please enter a numeric taxable income amount.");
        }
    }
}
