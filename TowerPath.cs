using System;
using System.Collections.Generic;
using System.Text;

namespace TowerHoppingProblem
{
  /* Class dedicated to tracking path through towers. Using a class in this way wasn't strictly necessary, 
      but it made debugging much when my functions could pass back both their results and how the code arrived
      at its conclusion. */
  public class TowerPath
  {
    private readonly List<int> _steps;
    private bool _result;
    public int[] Towers { get; protected set; }
    
    public TowerPath(int[] towers)
    {
      _steps = new List<int>();
      _steps.Add(0);
      _result = false;
      Towers = towers;
    }
    
    public void AddStep(int i)
    {
      _steps.Add(i);
      if (i >= Towers.Length) this._result = true;
    }
    
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(String.Format("Towers: [{0}]", String.Join(", ", this.Towers)));
      sb.AppendLine(String.Format("{0} : {1}", this._result, String.Join(" -> ", this._steps)));
      
      return sb.ToString();
    }
    
  }
}