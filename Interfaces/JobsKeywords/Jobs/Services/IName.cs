using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Inherit;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Services;

public interface IName:
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 1 level(s)
    IEnvironmentNavigation,
    IExtendsNavigation,
    IInheritNavigation,
    Needs.INeedsNavigation,
    Variables.IVariablesNavigation,
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
    IAliasNavigation,
    IEntryPointNavigation
{}

public interface INameAfterAlias:
    //going up 1 level(s)
    IAliasNavigation
{}

public interface INameNavigation{
    public IName Name(string serviceName);   
}

public interface INameAfterAliasNavigation{
    public INameAfterAlias Name(string serviceName);   
}