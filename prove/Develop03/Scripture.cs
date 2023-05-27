using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _scriptureReference;
    private List<Word> _scriptureWords;
    private List<int> _replacedIndices;

    public Scripture(Reference _scriptureReference, string _scriptureText)
    {
        this._scriptureReference = _scriptureReference;
        _scriptureWords = new List<Word>();
        _replacedIndices = new List<int>();
        ConvertTextToWords(_scriptureText);
    }

    private void ConvertTextToWords(string _scriptureText)
    {
        string[] _words = _scriptureText.Split(' ');
        foreach (string _word in _words)
        {
            _scriptureWords.Add(new Word(_word));
        }
    }
    
        private void HideRemainingWords()
    {
        foreach (var _word in _scriptureWords)
        {
            if (!_word.IsHidden())
            {
                _word.Hide();
            }
        }
        _replacedIndices.Clear();

        foreach (var _word in _scriptureWords)
        {
            if (_word.IsHidden())
            {
                _word.Show();
            }
        }
    }

    public int CountWordsLeft()
    {
        int _count = 0;
        foreach (Word _word in _scriptureWords)
        {
            if (!_word.IsHidden())
            {
                _count++;
            }
        }
        return _count;
    }

    private static Random _random = new Random();

    public void HideRandomWord()
    {
        int _rndIndex;
        do
        {
            _rndIndex = _random.Next(0, _scriptureWords.Count);
        } while (_replacedIndices.Contains(_rndIndex));

        _scriptureWords[_rndIndex].Hide();
        _replacedIndices.Add(_rndIndex);

        if (!HasWordsLeft())
        {
            HideAllWords();
        }
        else if (CountWordsLeft() <= 4)
        {
            HideRemainingWords();
        }
    }


    public void HideRandomWords(int _count)
    {
        int _removedCount = 0;
        while (_count > 0 && _removedCount < _count && CountWordsLeft() > 0)
        {
            int _rndIndex;
            do
            {
                _rndIndex = _random.Next(0, _scriptureWords.Count);
            } while (_replacedIndices.Contains(_rndIndex));

            if (!_scriptureWords[_rndIndex].IsHidden())
            {
                _scriptureWords[_rndIndex].Hide();
                _replacedIndices.Add(_rndIndex);
                _removedCount++;
            }
        }
    }


    public void HideAllWords()
    {
        foreach (Word _word in _scriptureWords)
        {
            _word.Hide();
        }
        _replacedIndices.Clear();
    }

    public override string ToString()
    {
        List<string> _wordList = new List<string>();
        foreach (Word _word in _scriptureWords)
        {
            _wordList.Add(_word.GetWord());
        }
        return $"{_scriptureReference.ToString()}\n{string.Join(" ", _wordList)}";
    }

    public bool HasWordsLeft()
    {
        return _scriptureWords.Exists(_word => !_word.IsHidden()) == true;
    }
}
