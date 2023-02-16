using _01.SingletonPattern;

public class Program
{
    private static void Main(string[] args)
    {
        var logger = LoggerSingleton.Instance;
        logger.LogToFile();

        LoggerSingleton.Instance.LogToFile();
    }
}