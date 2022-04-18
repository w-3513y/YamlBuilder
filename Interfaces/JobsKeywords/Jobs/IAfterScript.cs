using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IAfterScript: 
    IJobsNavigation_lvl_0,
    ITimeOutNavigation_lvl_1,
    ITriggerNavigation_lvl_1,
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface IAfterScriptNavigation_lvl_1{
    public IAfterScript AfterScript(string commands);
}