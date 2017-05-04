using System;

namespace TowerHoppingProblem
{
  public class BrainFactory
  {
    private static BrainFactory _instance;
    
    private BrainFactory() {}
    
    public static BrainFactory Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new BrainFactory();
        }
        return _instance;
      }
    }
    
    public TowerBrain GetBrain(Constants.Brain brain, int[] towers)
    {
      switch(brain)
      {
        case Constants.Brain.DynamicProgramming:
        {
          return new DPTowerBrain(towers);
        }
        case Constants.Brain.Simple:
        {
          return new SimpleTowerBrain(towers);
        }
        default:
        {
          return new SimpleTowerBrain(towers);
        }
      }
    }
  }
}