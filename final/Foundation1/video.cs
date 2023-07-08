// Video class
class Video
{
    // Each video has a title, author, duration, and list of commments
    public string title;
    public string author;
    public int duration;
    public Comment[] comments;

    // Video constructor
    public Video(string video_title, string video_author, int video_duration, Comment[] video_comments)
    {
        title = video_title; // Title of the video
        author = video_author; // Author of the video
        duration = video_duration; // Length of the video in seconds
        comments = video_comments; // Array of comment objects
    }

    // Function to print the details of each video to the console
    public void printVideoDetails()
    {
        Console.WriteLine("Video Title - " + title);
        Console.WriteLine("Video Author - " + author);
        Console.WriteLine("Video Duration - " + duration + " seconds");
        if (comments.Length > 0) // If the video has comments
        {
            // Print the number of comments and each comment in the list
            printNumComments();
            Console.WriteLine("Comments: ");
            foreach (Comment comment in comments)
            {
                comment.printComment();
            }
        }
        else // If the video doesn't have any comments
        {
            printNumComments();
        }
    }

    // Function that prints the number of comments in the video
    public void printNumComments()
    {
        Console.WriteLine("Number of comments in video: " + comments.Length);
    }

}