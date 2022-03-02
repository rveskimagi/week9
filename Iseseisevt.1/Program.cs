using System;
using System.IO;

namespace Iseseisevt._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // võimaldab kasutajal luua uus kaust ja uus file shopinglist, myshopinglist.txt

            string rootDirectory = @"C:\Users\rvesk\samples\wishList";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();
            string fileName = "myshopinglist.txt";

            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

        }
    }
}
