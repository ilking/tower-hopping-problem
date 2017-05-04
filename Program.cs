using System;
using System.Collections.Generic;

namespace TowerHoppingProblem
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<int[]> towerLists = new List<int[]> ();
      towerLists.Add(new int[] {4,2,0,0,2,0});
      towerLists.Add(new int[] {1,0});
      towerLists.Add(new int[] {1,3,5,3,1,0});
      
      foreach(int[] towers in towerLists)
      {
        TowerBrain stb = new SimpleTowerBrain(towers);
        TowerBrain dpb = new DPTowerBrain(towers);
        
        stb.Calculate();
        dpb.Calculate();
        
        Console.WriteLine(stb.ToString());
        Console.WriteLine(dpb.ToString());
        Console.WriteLine();
      }
    }
  }
}