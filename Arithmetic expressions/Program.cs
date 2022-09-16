//Плотников Кирилл 22-ИСП-2/2 Вариант-10
try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Vvedite chislo x = ");
    Double x = double.Parse(Console.ReadLine());
    Console.Write("Vvedite chislo y = ");
    Double y = double.Parse(Console.ReadLine());
    Double res = Math.Pow(((x + 1) / (x - 1)), x) + 18 * x * Math.Pow(y, 2);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{res:F2}");
    Console.ForegroundColor = ConsoleColor.Green;
}
catch (Exception ex)
{ Console.WriteLine(ex.ToString()); }
