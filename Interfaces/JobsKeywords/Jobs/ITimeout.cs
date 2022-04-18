using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface ITimeOut:
    IJobsNavigation_lvl_0,
    ITriggerNavigation_lvl_1,
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface ITimeOutNavigation_lvl_1{
    public ITimeOut TimeOut(string timeout);
}