using System.Globalization;

namespace testApp1;
					
public class Program
{
	public static void Main()
    {
        // Подготовить переменные для работы программы
        Dictionary<decimal, decimal> coordinates = new Dictionary<decimal, decimal>();
        string? buffer;
        string[] split;

        // Прочитать и отформатировать входные данные
        do
        {
            buffer = Console.ReadLine();
            if (buffer != null && buffer != "")
            {
                split = buffer.Split(',');
                coordinates.Add(Decimal.Parse(split[0], CultureInfo.InvariantCulture), Decimal.Parse(split[1], CultureInfo.InvariantCulture));
            }
        } while (buffer != null && buffer != "");

        // Отобразить отформатированные входные данные
        foreach (KeyValuePair<decimal, decimal> _ in coordinates)
        {
            Console.WriteLine("X: {0} Y: {1}", _.Key, _.Value);
        }
	}
}