using System;

public class Job
{
    public string _jobTitleName;
    public string _companyName;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitleName} ({_companyName}) {_startYear}-{_endYear}");
    }
}