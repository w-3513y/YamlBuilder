using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface ITrigger:
    IIncludeNavigation_lvl_2,
    IStrategyNavigation_lvl_2,
    IFowardNavigation_lvl_2
{}

public interface ITriggerShortSyntax:
    IJobsNavigation_lvl_0,
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface ITriggerNavigation_lvl_1{
    public ITrigger Trigger();
}