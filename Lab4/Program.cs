using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Town town = new Town();

Console.WriteLine("Введіть назву міста:");
town.Name = Console.ReadLine();

Console.WriteLine("Введіть назву країни:");
town.Country = Console.ReadLine();

Console.WriteLine("Введіть назву регіону:");
town.Region = Console.ReadLine();

Console.WriteLine("Введіть кількість населення:");
town.Population = int.Parse(Console.ReadLine());

Console.WriteLine("Введіть річний дохід міста:");
town.YearIncome = double.Parse(Console.ReadLine());

Console.WriteLine("Введіть площу міста:");
town.Square = double.Parse(Console.ReadLine());

Console.WriteLine("Чи має місто порт? (true/false):");
town.HasPort = bool.Parse(Console.ReadLine());

Console.WriteLine("Чи має місто аеропорт? (true/false):");
town.HasAirport = bool.Parse(Console.ReadLine());

double incomePerInhabitant = town.GetYearIncomePerInhabitant();

Console.WriteLine("\nІнформація про місто:");
Console.WriteLine($"Назва міста: {town.Name}\t\tКраїна: {town.Country}");
Console.WriteLine($"Регіон: {town.Region}\t\tНаселення: {town.Population}");
Console.WriteLine($"Річний дохід міста: {town.YearIncome}\t\tПлоща міста: {town.Square}");
Console.WriteLine($"Має порт: {town.HasPort}\t\tМає аеропорт: {town.HasAirport}");
Console.WriteLine($"Середній річний дохід на одного мешканця: {incomePerInhabitant}");

Console.ReadLine();
class Town
{
    public string Name;
    public string Country;
    public string Region;
    public int Population;
    public double YearIncome;
    public double Square;
    public bool HasPort;
    public bool HasAirport;
    public double GetYearIncomePerInhabitant()
    {
        return YearIncome / Population;
    }
}


