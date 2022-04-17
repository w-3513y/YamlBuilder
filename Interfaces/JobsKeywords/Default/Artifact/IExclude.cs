using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifacts.RepostTypes;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifacts;

public interface IExclude:
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
    IReportNavigation
{}

public interface IExcludeNavigation{
    public IExclude Exclude(string file);
    
}
/*
    Use artifacts:exclude to prevent files from being added to an artifacts archive.
    Keyword type: Job keyword. You can use it only as part of a job or in the default section.
*/