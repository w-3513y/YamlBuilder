using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IVariables:
    //going down 1 level(s)
    IKeyNavigation_lvl_1
{}

public interface IVariablesShortSyntax:
    //going up 1 level(s)
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0
{}

public interface IVariablesNavigation_lvl_0{
    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues);
    public IVariables Variables();
}
