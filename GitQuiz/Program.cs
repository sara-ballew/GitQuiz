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

            Console.WriteLine("6. What is the Git command to show modified files in working directory, staged for your next commit?");
            Console.WriteLine("Your answer is: ");
            bool correctAnswer6;
            do
            {
                string question6 = Console.ReadLine();
                string answer6 = ("git status");

                if (question6 == answer6)
                {
                    Console.WriteLine("Correct!");
                    correctAnswer6 = true;
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                    correctAnswer6 = false;
                }
            } while (correctAnswer6 == false);

            Console.WriteLine("7. What is the Git command to add a file as it looks now to your to your next commit (stage)?");
            Console.WriteLine("Your answer is: ");
            bool correctAnswer7;
            do
            {
                string question7 = Console.ReadLine();
                string answer7 = ("git add [file]");

                if (question7 == answer7)
                {
                    Console.WriteLine("Correct!");
                    correctAnswer7 = true;
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                    correctAnswer7 = false;
                }
            } while (correctAnswer7 == false);

            Console.WriteLine("8. What is the Git command to commit your new staged content as a commit snapshot?");
            Console.WriteLine("Your answer is: ");
            bool correctAnswer8;
            do
            {
                string question8 = Console.ReadLine();
                string answer8 = ("git commit -m \"[descriptive message]\"");

                if (question8 == answer8)
                {
                    Console.WriteLine("Correct!");
                    correctAnswer8 = true;
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                    correctAnswer8 = false;
                }
            } while (correctAnswer8 == false);

            Console.WriteLine("9. What is the Git command to merge the specified branch's history into the current one?");
            Console.WriteLine("Your answer is ");
            bool correctAnswer9;
            do
            {
                string question9 = Console.ReadLine();
                string answer9 = ("git merge [branch]");

                if (question9 == answer9)
                {
                    Console.WriteLine("Correct!");
                    correctAnswer9 = true;
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                    correctAnswer9 = false;
                }
            } while (correctAnswer9 == false);

            Console.WriteLine("10. What is the Git command to switch to another branch and check it out into your working directory?");
            Console.WriteLine("Your answer is");
            bool correctAnswer10;
            do
            {
                string question10 = Console.ReadLine();
                string answer10 = ("git checkout");

                if (question10 == answer10)
                {
                    Console.WriteLine("Correct!");
                    correctAnswer10 = true;
                }
                else
                {
                    Console.WriteLine("Incorrect! Try Again.");
                    correctAnswer10 = false;
                }
            } while (correctAnswer10 == false);
        }
    }
}

