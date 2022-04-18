using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface ITimeOut:
    //going up 3 level(s) abouve
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    ITriggerNavigation_lvl_1,
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface ITimeOutNavigation_lvl_1{
    public ITimeOut TimeOut(string timeout);
}