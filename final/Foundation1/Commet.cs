// Comment class, each comment contains the author string and text string
class Comment
{
    public string author;
    public string text;

    // Comment constructor
    public Comment(string comment_author, string comment_text)
    {
        author = comment_author;
        text = comment_text;
    }

    // Function to print the details of the comment in a formatted way
    public void printComment()
    {
        string formatted_comment = '"' + text + '"' + " - " + author;
        Console.WriteLine(formatted_comment);
    }
}