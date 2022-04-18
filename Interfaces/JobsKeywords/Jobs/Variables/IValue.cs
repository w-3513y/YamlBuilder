using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Variables;

public interface IValue:
    //going up 1 level(s)
    IJobsNavigation,
    //going up 1 level(s)
    IRulesNavigation,
    ITagsNavigation,
    IRetryNavigation,
    IAllowFailureNavigation,
    IArtifactsNavigation,
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
    IWhenNavigation,
    //going down 1 level(s)
    IDescriptionNavigation,
    //recursive mode that make possible to have more than one project included
    IKeyNavigation
 {}

public interface IValueNavigation{
    public IValue Value(string value);
}