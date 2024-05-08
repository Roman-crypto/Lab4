using System;
using System.Text;

Country country = new Country();

Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("Введіть назву країни:");
country.Name = Console.ReadLine();

Console.WriteLine("Введіть столицю:");
country.Capital = Console.ReadLine();

Console.WriteLine("Введіть кількість населення:");
country.Population = long.Parse(Console.ReadLine());

Console.WriteLine("Введіть площу (в квадратних кілометрах):");
country.Area = double.Parse(Console.ReadLine());

Console.WriteLine("Введіть мову:");
country.Language = Console.ReadLine();

Console.WriteLine("Чи є країна членом ООН? (true/false):");
country.IsUNMember = bool.Parse(Console.ReadLine());

Console.WriteLine("Введіть рівень розвитку (низький/середній/високий):");
country.DevelopmentLevel = Console.ReadLine();

double populationDensity = country.GetPopulationDensity();

Console.WriteLine("\nІнформація про країну:");
Console.WriteLine($"Назва країни: {country.Name}");
Console.WriteLine($"Столиця: {country.Capital}");
Console.WriteLine($"Населення: {country.Population} осіб");
Console.WriteLine($"Площа: {country.Area} км²");
Console.WriteLine($"Мова: {country.Language}");
Console.WriteLine($"Член ООН: {country.IsUNMember}");
Console.WriteLine($"Рівень розвитку: {country.DevelopmentLevel}");
Console.WriteLine($"Густота населення: {populationDensity:f0} осіб/км²");

Console.ReadLine();
class Country
{
    public string Name;
    public string Capital;
    public long Population;
    public double Area;
    public string Language;
    public bool IsUNMember;
    public string DevelopmentLevel;

    public double GetPopulationDensity()
    {
        return Population / Area;
    }
}
