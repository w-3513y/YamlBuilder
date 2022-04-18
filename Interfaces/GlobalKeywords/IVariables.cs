using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IVariables:
    IKeyNavigation_lvl_1
{}

public interface IVariablesShortSyntax:
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0
{}

public interface IVariablesNavigation_lvl_0{
    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues);
    public IVariables Variables();
}
