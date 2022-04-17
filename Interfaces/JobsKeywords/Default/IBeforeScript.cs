using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface IBeforeScript: 
    //going up 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation,
    //going up 1 level(s)
    ICacheNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation
{}

public interface IBeforeScriptNavigation{
    public IBeforeScript BeforeScript(string commands);
}