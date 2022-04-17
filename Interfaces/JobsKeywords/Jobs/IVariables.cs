using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IVariables:
    //going up 1 level(s)
    IJobsNavigation
{}

public interface IVariablesNavigation{
    public IVariables Variables(Dictionary<string, string> keyValues);
}
