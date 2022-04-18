using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;

public interface IVariables:
    //going up 2 level(s)
    IJobsNavigation,
    //going up 1 level(s)
    IIfsNavigation,
    //going down 1 level(s)
    IWhenNavigation,
    IAllowFailureNavigation    
   
 {}

public interface IVariablesNavigation{
    public IVariables Variables(string condition);
}