using System;
using System.Collections.Generic;

namespace TowerHoppingProblem
{
  public class Program
  {
  /** Given a list of integers representing towers of various heights, find out if its possible to escape the towers by jumping from one tower to another. 
     * You can only jump as far as the height of the current tower.
     */
    public static TowerPath IsHoppable(int[] towers)
    {
      int current = 0;
      TowerPath path = new TowerPath(towers);
      
      while (true)
      {
        if (towers[current] == 0) return path;
        
        int next_step = NextStep(towers, current);
        if (next_step >= towers.Length) 
        {
          path.AddStep(next_step);
          return path;
        }
        else {
          path.AddStep(next_step);
          current = next_step;
        }
      }
    }
    
    public static int NextStep(int[] towers, int current)
    {
      int max_i = current;
      int max_tower_value = current + towers[current];
      
      int curr_i = current + towers[current];
      
      while (curr_i > current)
      {
        if (curr_i >= towers.Length) return curr_i;
        
        if (curr_i + towers[curr_i] >= max_tower_value)
        {
          max_i  = curr_i;
          max_tower_value = curr_i + towers[curr_i];
        }
        
        curr_i--;
      }
      
      return max_i;
    }
  
    public static void Main(string[] args)
    {
      int[] towers_1 = new int[6] {4,2,0,0,2,0};
      Console.WriteLine(IsHoppable(towers_1));
      
      int[] towers_2 = new int[2] {1,0};
      Console.WriteLine(IsHoppable(towers_2));
      
      int[] towers_3 = new int[] {1,3,5,3,1,0};
      Console.WriteLine(IsHoppable(towers_3));
    }
  }
}