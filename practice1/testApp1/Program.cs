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
        var fileContent = File.ReadAllText(args[0]);
        Console.WriteLine(fileContent);

        // Отформатировать входные данные 

        // Отобразить отформатированные входные данные

	}
}