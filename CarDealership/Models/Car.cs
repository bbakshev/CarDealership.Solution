using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string CarMake {get; set;}
    public string CarModel {get; set;}
    public int CarYear {get; set;}
    public string CarColor {get; set;}

    private static List<Car> _instances = new List<Car> {};

    public Car(string carmake , string carmodel, int caryear, string carcolor)
    {
      CarMake = carmake;
      CarModel = carmodel;
      CarYear = caryear;
      CarColor = carcolor;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}