using System;
using System.Collections.Generic;
using System.Text;

namespace TowerHoppingProblem
{
  /** Given a list of integers representing towers of various heights, find out if its possible to escape the towers by jumping from one tower to another. 
     * You can only jump as far as the height of the current tower.
     */
  public abstract class TowerBrain
  {
    public int[] Towers { get; protected set; }
    
    public TowerBrain(int[] towers)
    {
      Towers = towers;
    }
    
    public abstract void Calculate();
    
    public override string ToString()
    {
      return String.Format("[{0}]", String.Join(", ", this.Towers));
    }
  }
}