public abstract class Goal
{
    private string _name;
    private int _value;
    private bool _itsComplete;

    protected Goal(string name, int value)
    {
        _name = name;
        _value = value;
        _itsComplete = false;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public bool ItsComplete
    {
        get { return _itsComplete; }
        set { _itsComplete = value; }
    }

    public abstract void Complete();

    public abstract string GetStatus();

    public abstract void Display();
}
