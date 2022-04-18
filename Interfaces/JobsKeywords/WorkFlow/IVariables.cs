using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IVariables:
    IJobsNavigation_lvl_0,
    IIfsNavigation_lvl_2,
    IWhenNavigation_lvl_3,
    IAllowFailureNavigation_lvl_3    
   
 {}

public interface IVariablesNavigation_lvl_3{
    public IVariables Variables(string condition);
}