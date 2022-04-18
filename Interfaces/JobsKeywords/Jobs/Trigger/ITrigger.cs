using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface ITrigger:
    IIncludeNavigation,
    IStrategyNavigation
{}

public interface ITriggerShortSyntax:
    //going up 3 level(s) abouve
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface ITriggerNavigation_lvl_1{
    public ITrigger Trigger();
}