using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;

public interface IPublic:
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    IBeforeScriptNavigation_lvl_1,
    ICacheNavigation_lvl_1,
    IInterruptibleNavigation_lvl_1,
    IRetryNavigation_lvl_1,
    IServicesNavigation_lvl_1,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    INameNavigation_lvl_2,
    IPathsNavigation_lvl_2,
    IExpireInNavigation_lvl_2,
    IExcludeNavigation_lvl_2,
    IExposeAsNavigation_lvl_2,
    IReportNavigation_lvl_2,
    IUntrackedNavigation_lvl_2,
    IWhenNavigation_lvl_2
{}

public interface IPublicNavigation_lvl_2{
    public IPublic Public(bool publ);
}
