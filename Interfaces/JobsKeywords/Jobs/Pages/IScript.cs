using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IScript:
    IJobsNavigation_lvl_0,
    IWhenNavigation_lvl_1,
    IArtifactNavigation_lvl_2,
    IRulesNavigation_lvl_2
{}

public interface IScriptNavigation_lvl_2{
    public IScript Script(string[] commands);
}