public class Entry
{
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime Time { get; set; }

    public Entry(string title, string text, DateTime time = default(DateTime))
    {
        Title = title;
        Text = text;
        Time = time == default(DateTime) ? DateTime.Now : time;
    }

    public override string ToString()
    {
        return $"Prompt: {Title}, Entry: {Text}, Time: {Time}";
    }
}