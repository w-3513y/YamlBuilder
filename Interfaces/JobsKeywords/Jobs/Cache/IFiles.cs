using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;

public interface IFiles:
    //going up 4 level(s) abouve
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
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
    Jobs.IWhenNavigation_lvl_1,
    //going up 1 level(s)
    IPathsNavigation,
    IWhenNavigation,
    IPolicyNavigation,
    IUntracked,
    //going down 1 level(s)
    IPrefixNavigation
{}

public interface IFilesNavigation{
    public IFiles Files(string[] files);   
}