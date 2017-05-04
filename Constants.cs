using System;
using System.Collections.Generic;

namespace TowerHoppingProblem
{
  public static class Constants
  {
    public enum Brain
    {
      DynamicProgramming,
      Simple
    }
    
    public readonly static List<Brain> AllBrains = new List<Brain>
    {
      Brain.DynamicProgramming,
      Brain.Simple
    };
  }
}