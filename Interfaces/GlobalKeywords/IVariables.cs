using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IVariables:
    //going down 1 level(s)
    IKeyNavigation
{}

public interface IVariablesShortSyntax:
    //going up 1 level(s)
    IWorkFlowNavigation,
    IJobsNavigation
{}

public interface IVariablesNavigation{
    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues);
    public IVariables Variables();
}
