//// Optional interactive version – user inputs number of random values
//using LotteryNumbers;

//while (true)
//{
//    Console.Write("Enter number of random integers (or 0 to quit): ");

//    if (!int.TryParse(Console.ReadLine(), out int n))
//    {
//        Console.WriteLine("Invalid input. Please enter a valid number.");
//        continue;
//    }

//    if (n == 0)
//    {
//        Console.WriteLine("Goodbye!");
//        break;
//    }

//    if (n < 0 || n > 49)
//    {
//        Console.WriteLine("Please enter a number between 1 and 49.");
//        continue;
//    }

//    List<int> randomNumbers = LotteryGenerator.GenerateNumbers(n);
//    int bonus = LotteryGenerator.GenerateBonusNumber(randomNumbers);
//    LotteryGenerator.DisplayNumbers(randomNumbers, bonus);
//    Console.WriteLine();

//}
