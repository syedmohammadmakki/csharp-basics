using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using static ConsoleApp1.Program.Post;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Design a class called Post. This class models a StackOverflow post.
            //            It should have properties
            //            for title, description and the date /
            //            time it was created.We should be able to up - vote or down - vote
            //            a post.We should also be able to see the current vote value.
            //            In the main method, create a post,
            //            up - vote and down - vote it a few times and then display the the current vote value.
            //            In this exercise, you will learn that a StackOverflow
            //            post should provide methods for up - voting
            //            and down - voting.You should not give the ability to set the Vote
            //            property from the outside,
            //            because otherwise, you may accidentally change the
            //            votes of a class to 0 or to a random
            //number.And this is how we create bugs in our programs.
            //The class should always protect its
            //state and hide its implementation detail.
           Post post = new Post("simba", "the lion king ",new DateTime());


            bool simba = true; 

            while (simba)
            {

            Console.Write("vote to simba :");
            string voteselector = Console.ReadLine();
                if (voteselector == "d")
                {
                    post.upvote();  

                }else if (voteselector == "u")
                {
                    post.downvote();
                }

            }

            Console.WriteLine(post.vote);

        }
        public class Post
        {
            public string  title { get; set; }
            public string description { get; set; }
             public int date {  get; set; }
            public int vote { get; set; }

            public Post(string title, string description, DateTime date)
            {
                vote = 0;
                title = title;
                description = description;
                date = date;

            }

            public void upvote()
            {
                    vote++;
                Console.WriteLine(vote);
            }

            public void downvote()
            {
    
                    vote--;
                Console.WriteLine(vote);
            }



          
          
          












        }
    }
} 
