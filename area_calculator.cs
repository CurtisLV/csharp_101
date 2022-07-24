using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(CalculateTotalCost());

    }

    static double Circle(double radius) {
      return Math.PI * Math.Pow(radius, 2);
    }
    static double Rect(double length, double width) {
      return length * width;
    }
    static double Triangle(double bottom, double height) {
      return 0.5 * bottom * height;
    }

    static string CalculateTotalCost() {
      // everything is hardcoded ...
      int costUnit = 180;
      double rect =  Rect(1500, 2500);
      double trissturis = Triangle(750, 500);
      double halfCirce = Circle(375/2) * 0.5; 

      double totalArea = rect + trissturis + halfCirce;
      totalArea = Math.Round(totalArea, 2);
      double totalCosts = totalArea * costUnit;
      return $"The total costs for the project are {totalCosts} pesos!";
    }

  }
}
