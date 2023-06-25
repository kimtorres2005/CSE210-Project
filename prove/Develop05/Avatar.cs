class Avatar
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int ExperiencePoints { get; set; }

    public Avatar(string name)
    {
        Name = name;
        Level = 1;
        ExperiencePoints = 0;
    }
}