using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface ITrigger:
    IIncludeNavigation,
    IStrategyNavigation
{}

public interface ITriggerShortSyntax:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface ITriggerNavigation{
    public ITrigger Trigger();
}