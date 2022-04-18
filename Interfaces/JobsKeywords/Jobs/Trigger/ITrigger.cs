using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface ITrigger:
    IIncludeNavigation,
    IStrategyNavigation
{}

public interface ITriggerShortSyntax:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    IPagesNavigation,
    IWhenNavigation
{}

public interface ITriggerNavigation{
    public ITrigger Trigger();
}