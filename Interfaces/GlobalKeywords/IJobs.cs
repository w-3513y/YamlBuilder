using YamlBuilder.Interfaces.JobsKeywords.Jobs;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Except;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Image;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Needs;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Only;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Services;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IJobs:
    IOnlyNavigation_lvl_1,
    IExceptNavigation_lvl_1,
    IImageNavigation_lvl_1,
    IServicesNavigation_lvl_1,
    IEnvironmentNavigation_lvl_1,
    IExtendsNavigation_lvl_1,
    JobsKeywords.Jobs.Inherit.IInheritNavigation_lvl_1,
    INeedsNavigation_lvl_1,
    JobsKeywords.Jobs.Variables.IVariablesNavigation_lvl_1,
    JobsKeywords.Jobs.Rules.IRulesNavigation_lvl_1,
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
    JobsKeywords.Jobs.IScriptNavigation_lvl_1,
    IAfterScriptNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    ITriggerNavigation_lvl_1,
    IPagesNavigation_lvl_1,
    JobsKeywords.Jobs.IWhenNavigation_lvl_1
{}

public interface IJobsNavigation_lvl_0{
    public IJobs Jobs(string[] stages);
}
