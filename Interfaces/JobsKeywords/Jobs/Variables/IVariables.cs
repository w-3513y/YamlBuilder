using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Variables;

public interface IVariables:
    //going down 1 level(s)
    IKeyNavigation
{}

public interface IVariablesShortSyntax:
    //going up 1 level(s)
    IJobsNavigation_lvl_0
{}

public interface IVariablesNavigation_lvl_1{
    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues);
    public IVariables Variables();
}
