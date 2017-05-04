using System;
using System.Collections.Generic;
using System.Text;

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
      
      BrainFactory bf = BrainFactory.Instance;
      
      List<string> outputs = new List<string>();
      
      foreach(int[] towers in towerLists)
      {
        StringBuilder sb = new StringBuilder();
        
        sb.AppendLine(String.Format("Towers: [{0}]", String.Join(", ", towers)));
        sb.AppendLine("");
        
        foreach(var brain in Constants.AllBrains)
        {
          var thinker = bf.GetBrain(brain, towers);
          thinker.Calculate();
          sb.AppendLine(thinker.ToString());
          sb.AppendLine("");
        }
        
        outputs.Add(sb.ToString());
      }
      
      Console.WriteLine(String.Join("=====================\n\n", outputs));
    }
  }
}