using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "I ";
      string middle = "am ";
      string end = "George";

      // Concatenate the string and the variables
      string story = beginning + middle + end;

      // Print the story to the console 
      Console.WriteLine(story + ".");
    }
  }
}
