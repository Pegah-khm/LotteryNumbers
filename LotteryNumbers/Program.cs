// See https://aka.ms/new-console-template for more information

using LotteryNumbers;

List<int> randomNumbers = LotteryGenerator.GenerateNumbers(6);
int bonus = LotteryGenerator.GenerateBonusNumber(randomNumbers);
LotteryGenerator.DisplayNumbers(randomNumbers, bonus);