using System;
using System.IO;

public class Journal
{
    private Prompt _prompts = new Prompt();

    private List<Entry> _entries = new List<Entry>();

    public void PromptsUserToWrite()
    {
        string prompt =_prompts.GetRandomPrompt();
        Console.Write(prompt + " ");
        string text = Console.ReadLine();

        Entry entry = new Entry(prompt, text);
        _entries.Add(entry);
        Console.WriteLine("Entry has saved: " + entry.ToString());
    }

    public void LoadEntriesFrom()
    {
        Console.WriteLine("Please enter the name of the file to be loaded: ");
        string _fileName = Console.ReadLine();
        
        if (!File.Exists(_fileName))
        { 
            Console.WriteLine("This file is not found.");
            return;
        }
        else
        {
            using (StreamReader _reader = new StreamReader(_fileName))
            {
                string _line;
                bool _firstLine = true;

                while ((_line = _reader.ReadLine()) !=null)
                {
                    if (_firstLine)
                    {
                        _firstLine = false;
                        continue;
                    }

                    string[] _parts = _line.Split(',');

                    if (_parts.Length >= 3)
                    {
                        string _prompt = _parts[0].Trim('"');
                        string _comment =_parts[1].Trim('"');
                        DateTime _time;
                        if (DateTime.TryParse(_parts[2], out _time))
                        {
                            Entry _entry = new Entry(_prompt, _comment, _time);
                            if (!_entries.Contains(_entry))
                            {
                                _entries.Add(_entry);
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine("Your file has been loaded.");
    }

    public void SaveEntries()
    {
        String _csvFilePath = "journal.csv";
        bool _fileExist = File.Exists(_csvFilePath);
        using (StreamWriter _writer = new StreamWriter(_csvFilePath, true))
        {
            if (!_fileExist)
            {
                _writer.WriteLine($"Prompt,Comment,Time");
            }
            foreach (Entry _entry in _entries)
            {
                _writer.WriteLine($"\"{_entry.Title}\",\"{_entry.Text}\",{_entry.Time}");
            }
        Console.WriteLine("Your file has been saved under journal.csv");
        }
    }

    public void displayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries were found, can not display.");
            return;
        }

        Console.WriteLine("Entries:");

        for (int i = 0; i < _entries.Count; i++)
        {
            Entry _entry = _entries[i];
            Console.WriteLine($"{i + 1}. {_entry.ToString()}");
        }
    } 
}  