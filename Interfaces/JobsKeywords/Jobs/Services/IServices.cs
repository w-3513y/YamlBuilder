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
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Services;

public interface IServices:
  //going down 1 level(s)
  INameNavigation
{}

public interface IServicesShortSyntax:
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 1 level(s)
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


public interface IServicesNavigation{
    public IServices Services();   
    public IServicesShortSyntax Services(string[] commands);
}