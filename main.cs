using System;
using System.Threading.Tasks;
using System.IO;

class Program{
    public static async Task Main()
    {
        string answer = null;
        var counter = 0;

        while (counter <= 9999)
        {
            Console.WriteLine("Do you want to quit? ('yes' or 'no')");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                counter = counter + 10000;
            }
            else if (answer == "no")
            {
                counter++;
                var newTotal = counter;
                await File.WriteAllTextAsync("WriteText.txt", newTotal.ToString());
                Console.WriteLine("File Created ...");

                var someText = await File.ReadAllTextAsync(@"WriteText.txt");
                Console.WriteLine(someText);
            }
            Console.WriteLine("\nDone");
        }
    }
}