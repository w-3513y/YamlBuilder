using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IDependencies:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    IInterruptibleNavigation,
    IParallelNavigation,
    IReleaseNavigation,
    IResourceGroupNavigation,
    IBeforeScriptNavigation,
    IScriptNavigation,
    IAfterScriptNavigation,
    ITimeOutNavigation,
    ITriggerNavigation,
    IPagesNavigation,
    IWhenNavigation
{}

public interface IDependenciesNavigation{
    public IDependencies Dependencies(string[] dependencies);
}