public class GoalTracker
{

    public (List<Goal> goals, int score) LoadGoalsFromFile(string fileName)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        using (StreamReader reader = new StreamReader(fileName))
        {
            if (!reader.EndOfStream)
            {
                string scoreLine = reader.ReadLine();
                score = int.Parse(scoreLine);
            }
            while (!reader.EndOfStream)
            {
                string[] goalData = reader.ReadLine().Split('|');

                string goalType = goalData[0];
                string name = goalData[1];
                int value = int.Parse(goalData[2]);
                bool itsComplete = bool.Parse(goalData[3]);
                int timesCompleted = int.Parse(goalData[4]);
                int requiredTimes = int.Parse(goalData[5]);
                int bonus = int.Parse(goalData[6]);

                Goal goal;

                switch (goalType)
                {
                    case nameof(SimpleGoal):
                        goal = new SimpleGoal(name, value, itsComplete);
                        break;
                    case nameof(EternalGoal):
                        goal = new EternalGoal(name, value, itsComplete);
                        break;
                    case nameof(ChecklistGoal):
                        goal = new ChecklistGoal(name, value, itsComplete, timesCompleted, requiredTimes, bonus);
                        break;
                    default:
                        Console.WriteLine("Invalid goal type in the file.");
                        continue;
                }

                goal.ItsComplete = itsComplete;
                goals.Add(goal);
            }
        }

        return (goals, score);
    }

    public void SaveGoalsToFile(List<Goal> goals, int score, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Value}|{goal.ItsComplete}|{checklistGoal.TimesCompleted}|{checklistGoal.RequiredTimes}|{checklistGoal.Bonus}");
                }
                else
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Value}|{goal.ItsComplete}|0|0|0");
                }
            }
        }
    }
}
