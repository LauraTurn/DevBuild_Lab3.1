using System;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Lab 3.1!");


            string reply = null;
            string otion = null;

            string[] name = { "Petunia", "Ernie", "Rose", "Oscar", "Tulip", "Burt" };
            string[] food = { "Frog Legs", "Deep Fried Butter", "Bat Necks", "Rat on a Stick", "Shark Eyes", "Duck Feet" };
            string[] animal = { "Atrax", "Black Mamba", "Chimera", "Komodo Dragon", "Dragon", "Poisonous Dart Frog" };

            bool over = false;
            while (!over)
            {
                //do
                //{
                Console.WriteLine("\nWelcome to our DEV.Build class. Here are all the students: \n");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"{name[i]}");
                }
                do
                {
                    Console.Write("Which student would you like to learn more about? (enter a number 1 - 6) ");
                    int user = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();

                    bool valid = (user == 1 || user == 2 || user == 3 || user == 4 || user == 5 || user == 6);
                    if (valid)
                    {
                        Console.WriteLine($"Student " + (user) + " is " + name[user - 1] + ".");

                        //do
                        //{

                        Console.Write("What would you like to know about " + name[user - 1] + "? (enter \"favorite food\" or \"favorite animal\")  ");
                        string option = Console.ReadLine();
                        Console.WriteLine();

                        bool super = (option == "favorite food" || option == "favorite animal");
                        if (super)
                        {
                            if (option == "favorite food")
                            {
                                Console.WriteLine(name[user - 1] + $"'s favorite food is " + food[user - 1] + ".");
                                over = true;
                            }
                            if (option == "favorite animal")
                            {
                                Console.WriteLine(name[user - 1] + $"'s favorite animal is a " + animal[user - 1] + ".");
                                over = true;
                            }
                        }
                        else
                        {
                            Console.Write("That data does not exist.  Next time please enter a valid answer!  (enter \"favorite food\" or \"favorite animal\"\n)  ");
                        }
                        Console.Write("Would you like to get to know another student? (yes/no) ");
                        reply = Console.ReadLine();
                        Console.WriteLine();
                    }
                    if (!valid)
                    {
                        Console.WriteLine("That student does not exist. Please enter a student number between 1 - 5 next time. \n");
                    }


                } while (reply == "yes");


                if (reply == "no")
                {
                    Console.WriteLine("Thanks!");
                }
            }



        }
    }

}