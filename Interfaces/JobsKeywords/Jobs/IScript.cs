using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IScript:
    //going up 3 level(s) abouve
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    IAfterScriptNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    ITriggerNavigation_lvl_1,
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface IScriptNavigation_lvl_1{
    public IScript Script(string[] commands);
}