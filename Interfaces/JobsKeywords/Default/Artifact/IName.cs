using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifacts.RepostTypes;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifacts;

public interface IName:
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
    IPathsNavigation,
    IExpireInNavigation,
    IExcludeNavigation,
    IExposeAsNavigation,
    IReportNavigation
{}

public interface INameNavigation{

    public IName Name(string name);
    
}
