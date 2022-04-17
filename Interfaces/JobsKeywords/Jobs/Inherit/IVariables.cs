using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Inherit;

public interface IVariables: 
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
{}

public interface IVariablesNavigation{
    public IVariables Variables(string[] variables);
    public IVariables Variables(bool yes);
}