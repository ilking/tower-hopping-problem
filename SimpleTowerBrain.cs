using System;
using System.Collections.Generic;
using System.Text;

namespace TowerHoppingProblem
{
  /** Given a list of integers representing towers of various heights, find out if its possible to escape the towers by jumping from one tower to another. 
     * You can only jump as far as the height of the current tower.
     */
  public class SimpleTowerBrain : TowerBrain
  {
    private readonly List<int> _steps;
    private bool _simpleResult;
    
    public SimpleTowerBrain(int[] towers) : base(towers)
    {
      _steps = new List<int>();
      _steps.Add(0);
      _simpleResult = false;
    }
    
    public override void Calculate() 
    {
    
      int current = 0;
      
      while (true)
      {
        if (Towers[current] == 0) 
        {
          _simpleResult = false;
          break;
        }
        else
        {
          int next_step = _NextStep(current);
          if (next_step >= Towers.Length) 
          {
            _steps.Add(next_step);
            _simpleResult = true;
            break;
          }
          else {
            _steps.Add(next_step);
            current = next_step;
          }
        }
      }
    }
    
    private int _NextStep(int current)
    {
      int max_i = current;
      int max_tower_value = current + Towers[current];
      
      int curr_i = current + Towers[current];
      
      while (curr_i > current)
      {
        if (curr_i >= Towers.Length) return curr_i;
        
        if (curr_i + Towers[curr_i] >= max_tower_value)
        {
          max_i  = curr_i;
          max_tower_value = curr_i + Towers[curr_i];
        }
        
        curr_i--;
      }
      
      return max_i;
    }
    
    public override string ToString() {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Simple Results:");
      sb.AppendLine(String.Format("Result: {0}", this._simpleResult));
      sb.Append(String.Format("Path: {0}", String.Join(" -> ", this._steps)));
      
      return sb.ToString();
    }
    
  }
}