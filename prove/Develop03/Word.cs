public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            string _underscore = "";
            for (int i = 0; i < _word.Length; i++)
            {
                _underscore += "_";
            }
            return _underscore;
        }
        else
        {
            return _word;
        }
    }
}
