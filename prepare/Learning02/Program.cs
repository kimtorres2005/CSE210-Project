using System;

class Program
{
    static void Main(string[] args)
    {
        Job joba = new Job();
        joba._jobTitleName = "Pharmacy Tech";
        joba._companyName = "T & T Pharmacy Inc.";
        joba._startYear = 2015;
        joba._endYear = 2021;

        Job jobb = new Job();
        jobb._jobTitleName = "Pharmacy Tech Manager";
        jobb._companyName = "CVS Pharmacy";
        jobb._startYear =  2021;
        jobb._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Kimberly Torres";

        myResume._jobs.Add(joba);
        myResume._jobs.Add(jobb);

        myResume.Display();
    }
}