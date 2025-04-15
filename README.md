# LotteryNumbers
**Author:** Pegah Khodakarami

This C# console application was created as part of Dubber's technical challenge. It simulates a lottery number generator.

## ✅ Features
- Generates 6 unique random numbers between 1 and 49
- Sorts and displays the numbers in numerical order
- Adds a bonus ball, which is also unique and drawn after the original 6 numbers
- Applies colour-coded output based on number ranges:
  1–9: Grey
  10–19: Blue
  20–29: Pink (Magenta)
  30–39: Green
  40–49: Yellow

**Note:** I also put another file named "InteractiveVersion.cs" which is commented. This code accepts user input for how many random numbers to generate which is more realistic in the real world.It also supports multiple draws in a loop until the user enters 0.

## 💡 Design Decisions
- Top-level statements used for a modern C# feel
- Logic separated into a static utility class to enhance modularity and reusability

## 🕒 Time Spent
Approximately 1.5 to 2 hours, including testing, refactoring, and implementing extra features.

## 🚀 How to Run
1- Open the project in Visual Studio or VS Code
2- Build and run the project
3- For interactive version, enter how many random numbers you'd like to generate (between 1 and 49)
4- View your numbers, bonus ball, and repeat or exit as needed

📸 Sample Output
Enter number of random integers (or 0 to quit): 6
Your lottery numbers are:
Main numbers: 8 12 19 27 35 42 
Bonus Ball: 10

