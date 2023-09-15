namespace Topic_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respond, awnser, numb, number, number2, sum;
            double number3, number4, number5;
            Random generator = new Random();
            Console.WriteLine("Hello, could you please give me a minimum for a range of number.");
            respond = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now please give me a maximum.");
            awnser = Convert.ToInt32(Console.ReadLine());
            if (awnser < respond) {
                Console.WriteLine("Maximum is larger then minimum. Cannot process. Goodbye.");
                
            }

            if (awnser > respond)
            {
                numb = generator.Next(respond, awnser);
                Console.WriteLine("Ok, here are the numbers I got.");
                Console.WriteLine(numb);
                numb = generator.Next(respond, awnser);
                Console.WriteLine(numb);
                numb = generator.Next(respond, awnser);
                Console.WriteLine(numb);
                numb = generator.Next(respond, awnser);
                Console.WriteLine(numb);
                numb = generator.Next(respond, awnser);
                Console.WriteLine(numb);

                Console.WriteLine();
                Console.WriteLine("Hello, today we will role some dice today.");
                Console.ReadLine();
                number = generator.Next(1, 7);
                number2 = generator.Next(1, 7);
                sum = number + number2;
                Console.WriteLine($"The numbers are {number} and {number2}, and the sum is {sum}");

                Console.WriteLine($"The maximum and minimum from earlier will now be used once again. Just a reminder you chose {respond} and {awnser}. When ready, press enter.");
                Console.ReadLine();
                number3 = generator.Next(respond, awnser) + generator.NextDouble();
                number4 = generator.Next(respond, awnser) + generator.NextDouble();
                number5 = generator.Next(respond, awnser) + generator.NextDouble();
                Console.WriteLine($"The results are {number3}, {number4}, {number5}.");
            }
        }
    }
}