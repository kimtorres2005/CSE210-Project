using System;

// Main class
class Program1
{
    // Main function for running the program
    static void Main(string[] args)
    {
        // Creating the first video
        string video1_title = "My House Tour";
        string video1_author = "John Doe";
        int video1_duration = 567;
        Comment[] video1_comments =
        {
            new Comment("John Doe", "Thanks for watching!"),
            new Comment("James", "I really enjoyed the video!"),
            new Comment("Bob", "This video was cool."),
            new Comment("Sue", "Should have been a longer video!")
        };
        Video video1 = new Video(video1_title, video1_author, video1_duration, video1_comments);

        // Creating the second video
        string video2_title = "Testing";
        string video2_author = "Administrator";
        int video2_duration = 123;
        Comment[] video2_comments =
        {
            new Comment("John", "What is this video?"),
            new Comment("Admin", "Testing completed."),
            new Comment("Billy", "Interesting video.")
        };
        Video video2 = new Video(video2_title, video2_author, video2_duration, video2_comments);

        // Creating the third video
        string video3_title = "Watching Pigs Fly";
        string video3_author = "FunnyGuy15";
        int video3_duration = 47;
        Comment[] video3_comments =
        {
            new Comment("Joe Buck", "This is too funny!"),
            new Comment("RandomUser", "Hahahaha xD"),
            new Comment("Frank", "Thank you so much for this!"),
            new Comment("Ezra", "This is unreal!!!")
        };
        Video video3 = new Video(video3_title, video3_author, video3_duration, video3_comments);

        // Putting each video in a list, and iterating through them to print the details
        Video[] videos = { video1, video2, video3 };
        foreach (Video vid in videos)
        {
            vid.printVideoDetails();
            Console.WriteLine();
        }
    }
}