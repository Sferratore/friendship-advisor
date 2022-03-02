using System;


namespace FriendshipAdvisor;

class Program
{
    static void Main(string[] args)
    {

        Profile p1 = new Profile("Sam", 18, "Cicciarma", "Cicciogamer89", new string[3] { "mangiare", "bere", "dormire" });

        Console.WriteLine(p1.ViewProfile());
        return;
    }

}
