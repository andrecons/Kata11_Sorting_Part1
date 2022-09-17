using Kata11_Sorting_Part1.Objects.Controller;

Console.WriteLine("Welcome to the Pragraitic lottery!");
Console.Write("How many balls do you want to draw out?: ");
int inputBallsToDraw = Int16.Parse(Console.ReadLine());

LotteryController.Start(inputBallsToDraw);
