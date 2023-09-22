using System;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I love math!");
                    break;

                case "english":
                    Console.WriteLine("I enjoy the writting part of english.");
                    break;

                case "science":
                    Console.WriteLine("Science labs are fun, but i would sometimes get lost.");
                    break;

                case "social studies":
                    Console.WriteLine("I was not a fan of socia studies, it just bored me!");
                    break;

                case "physical education":
                    Console.WriteLine("Yes!! P.E. was where we had all the fun!");
                    break;

                default:
                    Console.WriteLine("I dont know of that subject.");
                    break;
            }
        }
    }
}