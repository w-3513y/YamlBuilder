using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IVariables:
    //going up 2 level(s)
    IJobsNavigation_lvl_0,
    //going up 1 level(s)
    IIfsNavigation_lvl_2,
    //going down 1 level(s)
    IWhenNavigation_lvl_3,
    IAllowFailureNavigation_lvl_3    
   
 {}

public interface IVariablesNavigation_lvl_3{
    public IVariables Variables(string condition);
}