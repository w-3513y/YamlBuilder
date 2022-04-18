using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact;

public interface IPaths:
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    ICacheNavigation,
    ICoverageNavigation,
    ISecretsNavigation,
    IDependenciesNavigation,
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
    Jobs.IWhenNavigation,
    //going up 1 level(s)
    IExpireInNavigation,
    IExcludeNavigation,
    IReportNavigation
{}

public interface IPathsNavigation{

    public IPaths Paths(string[] paths);
    
}