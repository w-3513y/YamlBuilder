using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Inherit;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Needs;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Services;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Image;

public interface IImage:
    //going down 1 level(s)
    INameNavigation,
    IEntryPointNavigation
{}

public interface IImageShortSintax:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //going up 1 level(s)
    IServicesNavigation,
    IEnvironmentNavigation,
    IExtendsNavigation,
    IInheritNavigation,
    INeedsNavigation,
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
    IWhenNavigation
{}

public interface IImageNavigation{

    public IImage Image();
    public IImageShortSintax Image(string image);
    
}