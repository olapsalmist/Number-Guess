using System;
using System.Collections.Generic;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int Easy = 1;
            int Medium = 2;
            int Hard = 3;
            int Levels = 0;
            string name = "";
            bool gameOver = false;
            int guess;
            int guessnum = 6;

            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome " +name+ " let's play the number guess game.");
            Console.WriteLine();
            Console.WriteLine("There are three levels in this game, they are Level 1, Level 2 and Level 3");
            Console.WriteLine("");
            Console.WriteLine("Level 1 is Easy: You guess between number 1-10 and you have 6 guesses");
            Console.WriteLine();
            Console.WriteLine("Level 2 is Medium: You guess between number 1-20 and you have 4 guesses");
            Console.WriteLine();
            Console.WriteLine("Level 3 is Hard: You guess between number 1-50 and you have 3 guesses");
            Console.WriteLine();
            Console.WriteLine("Now select your preferred level");
            Levels = int.Parse(Console.ReadLine());

        if (Levels==Easy)
        {
            int randomnum = random.Next(1, 11);
            Console.WriteLine();
            Console.WriteLine("You have selected level 1 (Easy)");
            Console.WriteLine();
            Console.Write( name+ ", I'm thinking of a number, what is it:");
            
            while (gameOver == false)
            {
                guessnum--;
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess != randomnum && guessnum == 0)
                {
                    Console.WriteLine("You have been unable to guess the number after 6 guesses. Game over");
                    gameOver = true;
                } else if (guess==randomnum)
                {
                    Console.WriteLine();
                    Console.WriteLine("correct, " +guess+ " is the right number");
                    gameOver=true;
                } else if (guess<randomnum)
                {
                    Console.WriteLine("Awwwwww, " +guess+ " is a wrong guess");
                    Console.WriteLine();
                    Console.WriteLine("Number of guess left is " +guessnum);
                    Console.WriteLine();
                } else if (guess>randomnum)
                {
                    Console.WriteLine("Awwwwww, " +guess+ " is a wrong guess");
                    Console.WriteLine();
                    Console.WriteLine("Number of guess left is " +guessnum);
                    Console.WriteLine();
                }
            }
        }
        if (Levels==Medium)
        {
            guessnum = 4;
            int randomnum = random.Next(1, 21);
            Console.WriteLine();
            Console.WriteLine("You have selected level 2 (Medium)");
            Console.WriteLine();
            Console.WriteLine("Level 2 is Medium: You guess between number 1-20 and you have 4 guesses");
            Console.WriteLine();
            Console.Write( name+ ", I'm thinking of a number, what is it:");
            
            while (gameOver == false)
            {
                guessnum--;
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess != randomnum && guessnum == 0)
                {
                    Console.WriteLine("You have been unable to guess the number after 4 guesses. Game over");
                    gameOver = true;
                } else if (guess==randomnum)
                {
                    Console.WriteLine();
                    Console.WriteLine("correct, " +guess+ " is the right number");
                    gameOver=true;
                } else if (guess<randomnum)
                {
                    Console.WriteLine("Awwwwww, the number is greater than " +guess);
                    Console.WriteLine();
                    Console.WriteLine("Number of guess left is " +guessnum);
                    Console.WriteLine();
                } else if (guess>randomnum)
                {
                    Console.WriteLine("Awwwwww, the number is lesser than " +guess);
                    Console.WriteLine();
                    Console.WriteLine("Number of guess left is " +guessnum);
                    Console.WriteLine();
                }
            }
        }  
        if (Levels==Hard)
        {
            guessnum = 3;
            int randomnum = random.Next(1, 51);
            Console.WriteLine();
            Console.WriteLine("You have selected level 3 (Hard)");
            Console.WriteLine();
            Console.WriteLine("Level 3 is Hard: You guess between number 1-50 and you have 3 guesses");
            Console.WriteLine();
            Console.Write( name+ ", I'm thinking of a number, what is it:");
            
            while (gameOver == false)
            {
                guessnum--;
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess != randomnum && guessnum == 0)
                {
                    Console.WriteLine("You have been unable to guess the number after 3 guesses. Game over.");
                    gameOver = true;
                } else if (guess==randomnum)
                {
                    Console.WriteLine();
                    Console.WriteLine("correct, " +guess+ " is the right number");
                    gameOver=true;
                } else if (guess<randomnum)
                {
                    Console.WriteLine("Awwwwww, the number is greater than " +guess);
                    Console.WriteLine();
                    Console.WriteLine("Number of guess left is " +guessnum);
                    Console.WriteLine();
                } else if (guess>randomnum)
                {
                    Console.WriteLine("Awwwwww, the number is lesser than " +guess);
                    Console.WriteLine();
                    Console.WriteLine("Number of guess left is " +guessnum);
                    Console.WriteLine();
                }
            }
        }      
    }
}
}