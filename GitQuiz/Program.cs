using System;

namespace GitQuiz
{
    class IfStatement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Sara's Git Command Prompt Quiz! Some of these are tricky! Don't forget to add [branch] or [alias] where necessary!");
            Console.WriteLine("1. What is the Git command to initialize an existing directory as a Git repository?");
            Console.WriteLine("Your answer is: ");
            bool correctAnswer1;
            do
            {
                string question1 = Console.ReadLine();

                string answer1 = ("git init");

                if (question1 == answer1)
                {
                    Console.WriteLine("Correct!");
                    correctAnswer1 = true;
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                    correctAnswer1 = false;
                }
            } while (correctAnswer1 == false);

            Console.WriteLine("2. What is the Git command to create a new branch at the current commit?");
            Console.WriteLine("Your answer is: ");
            bool correctAnswer2;
            do
            {
                string question2 = Console.ReadLine();
                string answer2 = ("git branch [branch-name]");

                if (question2 == answer2)
                {
                    Console.WriteLine("Correct!");
                    correctAnswer2 = true;
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                    correctAnswer2 = false;
                }
            } while (correctAnswer2 == false);

            Console.WriteLine("3. What is the Git command to fetch down all the branches from that Git remote?");
            Console.WriteLine("Your answer is: ");
            bool correctAnswer3;
            do
            {
                string question3 = Console.ReadLine();
                string answer3 = ("git fetch [alias]");

                if (question3 == answer3)
                {
                    Console.WriteLine("Correct!");
                    correctAnswer3 = true;
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                    correctAnswer3 = false;
                }
            } while (correctAnswer3 == false);

            Console.WriteLine("4. What is the Git command to retrieve an entire repository from a hosted location via URL?");
            Console.WriteLine("Your answer is: ");
            bool correctAnswer4;
            do
            {
                string question4 = Console.ReadLine();
                string answer4 = ("git clone [url]");

                if (question4 == answer4)
                {
                    Console.WriteLine("Correct!");
                    correctAnswer4 = true;
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                    correctAnswer4 = false;
                }
            } while (correctAnswer4 == false);

            Console.WriteLine("5. What is the Git command to transmit local branch commits to the remote repository branch?");
            Console.WriteLine("Your answer is: ");
            bool correctAnswer5;
            do
            {
                string question5 = Console.ReadLine();
                string answer5 = ("git push [alias] [branch]");

                if (question5 == answer5)
                {
                    Console.WriteLine("Correct!");
                    correctAnswer5 = true;
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                    correctAnswer5 = false;
                }
            } while (correctAnswer5 == false);
        }
    }
}

