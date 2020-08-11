using System;

namespace VariablesCs
{
  class Program
  {
    static void Main(string[] args)
    {
      var numberOfCupsOfCoffee = 0; 
      string fullName = "Byron";
      string today = "8/11/2020";
      Console.WriteLine("my name is " + fullName + " todays is " + today + " and i dranked " + numberOfCupsOfCoffee + " cups of coffee today.");
      Console.WriteLine("What is your name");
      string username = Console.ReadLine();
      Console.WriteLine(" hello " + username);
      Console.WriteLine("Please submit first number");
      string firstNumberAsString = Console.ReadLine();
      Console.WriteLine("Please submit second number");
      string secondNumberAsString = Console.ReadLine();
      double firstOperand = Double.Parse(firstNumberAsString);
      double secondOperand = Double.Parse(secondNumberAsString);

      double sum = firstOperand + secondOperand;
      double difference = firstOperand - secondOperand;
      double product = firstOperand * secondOperand;
      double quotient = firstOperand / secondOperand;
      double remainder = firstOperand % secondOperand;

     Console.WriteLine ($"did you know {sum} is the sum of {firstOperand} + {secondOperand}");
     Console.WriteLine ($"did you know {difference} is the difference of {firstOperand} - {secondOperand}");
     Console.WriteLine ($"did you know {product} is result when you multiply {firstOperand} and {secondOperand}");
     Console.WriteLine ($"did you know {quotient} is result when you divide {firstOperand} and {secondOperand}");
     Console.WriteLine ($"did you know  {remainder} is the remainder of {firstOperand} and {secondOperand}");

      


    }
  }
}
