using System;

// Comment class, each comment contains the author string and text string
class Comment
{
    public string Author;
    public string Text;

    // Comment constructor
    public Comment(string commentAuthor, string commentText)
    {
        Author = commentAuthor;
        Text = commentText;
    }

    // Function to print the details of the comment in a formatted way
    public void PrintComment()
    {
        string formattedComment = '"' + Text + '"' + " - " + Author;
        Console.WriteLine(formattedComment);
    }
}