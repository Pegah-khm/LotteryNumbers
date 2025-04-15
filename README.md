# 🎲 LotteryNumbers
**Author:** Pegah Khodakarami

This C# console application generates 6 unique random lottery numbers between 1 and 49, sorts them in ascending order, assigns background colours based on number ranges, and includes a bonus ball. The application was developed as part of a coding challenge.


### ✅ Features
- Generates 6 unique random numbers between 1 and 49
- Sorts numbers in ascending order
- Adds a bonus ball, which is also unique and drawn after the original 6 numbers
- Assigns background colours:
  1–9: Grey
  10–19: Blue
  20–29: Pink
  30–39: Green
  40–49: Yellow
- Generates a unique bonus ball
- Optional interactive version for user-defined number generation

### 📁 Project Structure
- `Program.cs`: Main application entry point
- `LotteryGenerator.cs`: Contains methods for number generation and display
- `InteractiveVersion.cs`: Optional interactive version (commented out to avoid compilation issues)

### 🚀 How to Run
1- Clone the repository
2- Open the solution in Visual Studio
3- Build and run the project

To explore the interactive version:
1- Uncomment the code in InteractiveVersion.cs.
2- Comment out the code in Program.cs to avoid conflicts with top-level statements.

