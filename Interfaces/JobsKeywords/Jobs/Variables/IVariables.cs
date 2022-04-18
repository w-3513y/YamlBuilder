using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Variables;

public interface IVariables:
    IKeyNavigation_lvl_2
{}

public interface IVariablesShortSyntax:
    IJobsNavigation_lvl_0
{}

public interface IVariablesNavigation_lvl_1{
    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues);
    public IVariables Variables();
}
