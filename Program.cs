// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// S = 1 + (1!/x) + (2!/x^2) + ... + (n!/x^n)

// Console.Write("Enter value for n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter value for x: ");
// int x = Convert.ToInt32(Console.ReadLine());

// double nFactorial = 1;
// double power = 1;
// double sum = 1;

// for(int k = 1; k <= n; k++)
// {
//     power *= x;
//     nFactorial *= k / power;
//     sum += nFactorial;
// }

// Console.WriteLine("S = " + sum);

// Console.Write("Enter value for a: ");
// double a = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter value for b: ");
// double b = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter value for height: ");
// double h = Convert.ToDouble(Console.ReadLine());

// double s = ((a + b )* h) / 2;

// Console.WriteLine("S = " + s);

Console.Write("Enter a positive integer N ( N < 20 ): ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    for(int j = i; j <= i + n - 1; j++)
    {
        Console.Write(" " + j);
    }
    Console.WriteLine();
}