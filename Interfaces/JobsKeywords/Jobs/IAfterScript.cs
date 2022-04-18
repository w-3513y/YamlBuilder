using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IAfterScript: 
    //going up 3 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    ITimeOutNavigation,
    ITriggerNavigation,
    IPagesNavigation,
    IWhenNavigation
{}

public interface IAfterScriptNavigation{
    public IAfterScript AfterScript(string commands);
}