using System;
using System.Collections.Generic;
using System.Text;

namespace TowerHoppingProblem
{
  /** Given a list of integers representing towers of various heights, find out if its possible to escape the towers by jumping from one tower to another. 
     * You can only jump as far as the height of the current tower.
     */
  public class DPTowerBrain : TowerBrain
  {
    private bool[] _dpFinds;
    private bool _dpResult;
    
    public DPTowerBrain(int[] towers) : base(towers)
    {
      _dpResult = false;
      _dpFinds = new bool[towers.Length];
    }
    
    public override void Calculate() 
    {
      int i = Towers.Length - 1;
      
      while (i >= 0)
      {
        if (i + Towers[i] >= Towers.Length)
        {
          _dpFinds[i] = true;
        }
        else
        {
          _dpFinds[i] = false;
          for (int j = i+1; j <= i + Towers[i]; j++)
          {
            if (j >= Towers.Length || _dpFinds[j] == true)
            {
              _dpFinds[i] = true;
              break;
            }
          }
        }
        i--;
      }
      
      _dpResult = _dpFinds[0];
    }
    
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Dynamic Results:");
      sb.AppendLine(String.Format("Results: {0}", this._dpResult));
      sb.Append(String.Format("Findings: [{0}]", String.Join(", ", this._dpFinds)));
      
      return sb.ToString();
    }
    
  }
}