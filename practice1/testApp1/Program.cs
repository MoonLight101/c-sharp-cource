namespace testApp1;
					
public class Program
{
	public static void Main(string[] args)
    {
        // Прочитать входные данные
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter a file name as an argument.");
            return;
        }
        string fileContent = File.ReadAllText(args[0]);

        // Отформатировать входные данные 
        string[] coordinates = fileContent.Split('\n');
        for (int i = 0; i < coordinates.Length; i++)
        {
            coordinates[i] = coordinates[i].Replace(',', ' ');
            coordinates[i] = coordinates[i].Replace('.', ',');
            coordinates[i] = "X: " + coordinates[i];
        }
        foreach (var number in coordinates)
        {
            Console.WriteLine($"{number}");
        }

        // Отобразить отформатированные входные данные

	}
}