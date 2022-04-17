using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifacts.RepostTypes;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifacts;

public interface IPaths:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation,
    //going up 2 level(s)
    IBefore_ScriptNavigation,
    ICacheNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 1 level(s)
    IExpireInNavigation,
    IExcludeNavigation,
    IReportNavigation
{}

public interface IPathsNavigation{

    public IPaths Paths(string[] paths);
    
}