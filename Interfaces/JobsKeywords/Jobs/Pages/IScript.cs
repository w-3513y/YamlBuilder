using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IScript:
    IJobsNavigation,
    //going up 2 level(s)
    IWhenNavigation,
    //going up 3 level(s) abouve
    IArtifactNavigation,
    IRulesNavigation
{}

public interface IScriptNavigation{
    public IScript Script(string[] commands);
}