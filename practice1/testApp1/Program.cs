using System.Text.RegularExpressions;
namespace testApp1;
					
public class Program
{
	public static void Main(string[] args)
    {
        // Прочитать входные данные
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter a txt file name as an argument.");
            return;
        }
        string fileContent = File.ReadAllText(args[0]);

        // Отформатировать входные данные 
        var result = new Regex("\r\n");
        fileContent = result.Replace(fileContent, " ");

        string[] numbers = fileContent.Split(',', ' ');
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i].Replace('.', ',');
        }

        string[] coordinates = new string[numbers.Length / 2];
        int j = 0;
        for (int i = 0; i < coordinates.Length; i++)
        {
            coordinates[i] = String.Format("Z: {0} Y: {1}", numbers[j], numbers[j + 1]);
            j += 2;
        }

        // Отобразить отформатированные входные данные
        foreach (var coordinate in coordinates)
        {
            Console.WriteLine($"{coordinate}");
        }

	}
}