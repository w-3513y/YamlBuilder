using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface ITimeOut:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    ITriggerNavigation,
    IPagesNavigation,
    IWhenNavigation
{}

public interface ITimeOutNavigation{
    public ITimeOut TimeOut(string timeout);
}