using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;

public interface IExclude:
    //going up 4 level(s) abouve
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    IBeforeScriptNavigation_lvl_1,
    ICacheNavigation_lvl_1,
    IInterruptibleNavigation_lvl_1,
    IRetryNavigation_lvl_1,
    IServicesNavigation_lvl_1,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    //going up 1 level(s)
    IExpireInNavigation_lvl_2,
    IReportNavigation_lvl_2
{}

public interface IExcludeNavigation_lvl_2{
    public IExclude Exclude(string file);
    
}
/*
    Use artifacts:exclude to prevent files from being added to an artifacts archive.
    Keyword type: Job keyword. You can use it only as part of a job or in the default section.
*/