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
    IJobsNavigation_lvl_0,
    //going up 1 level(s)
    IEnvironmentNavigation_lvl_1,
    IExtendsNavigation_lvl_1,
    IInheritNavigation_lvl_1,
    Needs.INeedsNavigation_lvl_1,
    Variables.IVariablesNavigation_lvl_1,
    IRulesNavigation,
    ITagsNavigation_lvl_1,
    IRetryNavigation_lvl_1,
    IAllowFailureNavigation_lvl_1,
    IArtifactsNavigation_lvl_1,
    ICacheNavigation_lvl_1,
    ICoverageNavigation_lvl_1,
    ISecretsNavigation_lvl_1,
    IDependenciesNavigation_lvl_1,
    IInterruptibleNavigation_lvl_1,
    IParallelNavigation_lvl_1,
    IReleaseNavigation_lvl_1,
    IResourceGroupNavigation_lvl_1,
    IBeforeScriptNavigation_lvl_1,
    IScriptNavigation_lvl_1,
    IAfterScriptNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    ITriggerNavigation_lvl_1,
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1,
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