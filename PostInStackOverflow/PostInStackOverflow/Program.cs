using System;

namespace PostInStackOverflow
{
    class Post
    {
        /* 
            ***** Φτιάχνω αντικείμενα *****
        */
        public string title { get; set; }
        public string description { get; set; }
        public DateTime dateCreated { get; } = DateTime.Now;
        public int countVote { get; set; } = 0;

        /* 
            ***** Φτιάχνω μεθόδους *****
        */

        // Θετική ψήφος
        public void VoteUp()
        {
            countVote += 1;
        }

        // Αρνητική ψήφος
        public void VoteDown()
        {
            countVote -= 1;
        }

        // Δείχνω το Post μου στο StackOverFlow
        public void showPost()
        {
            Console.WriteLine(title + "\r\n");
            Console.WriteLine(description + "\r\n");
            Console.WriteLine(String.Format("Τελική βαθμολογία: {0}", countVote));
            Console.WriteLine(String.Format("Δημοσιεύτηκε: {0} και ώρα: {1}", dateCreated.ToShortDateString().ToString(), dateCreated.ToShortTimeString().ToString()));

        }

        // Εδώ ξεκινάω ένα δείγμα
        static void Main(string[] args)
        {
            var newPost = new Post();

            newPost.title = "How do I set up Visual Studio Code to compile C# code?";
            newPost.description = "This assumes that there is a folder build in the root of the workspace with a CMake configuration.\r\nThere's also a CMake integration extension that adds a \"CMake build\" command to VScode.";

            // Ψηφίζουμε εγώ, ο Βελντές και ο Τσίγκος
            newPost.VoteUp();
            newPost.VoteUp();
            newPost.VoteUp();

            // Ψηφίζει ο Γιαλούρης και ο Ορφανός
            newPost.VoteDown();
            newPost.VoteDown();

            // Καλώ τη μέθοδο που μου δείχνει αναλυτικά όλα τα στοιχεία
            newPost.showPost();
            // Παγώνω την κονσόλα
            Console.ReadLine();

        }

    }
}
