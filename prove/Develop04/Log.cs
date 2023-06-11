using System.Threading;


public class Log {

    private static string _filePath = "Log.txt";

    public static void AppendLog(string _activity, int _duration, int _count = 0){
        string _logInput = $"{_activity}, {_duration} seconds,";
        if (_count > 0){
            _logInput += $" {_count} items listed,";
        }
        _logInput += $" {DateTime.Now}";
        File.AppendAllText(_filePath, _logInput + Environment.NewLine);
    }

    public static void DisplayLog(){
        string _logInfo = File.ReadAllText(_filePath);
        Console.WriteLine(_logInfo);
    }

    public static void ClearLog(){
        File.WriteAllText(_filePath, string.Empty);
        Console.WriteLine("The log has been cleared");
    }
}