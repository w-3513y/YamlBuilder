using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Cache;

public interface IFiles:
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    IInterruptibleNavigation_lvl_1,
    IRetryNavigation_lvl_1,
    IServicesNavigation_lvl_1,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    IPathsNavigation_lvl_2,
    IWhenNavigation_lvl_2,
    IPolicyNavigation_lvl_2,
    IUntrackedNavigation_lvl_2,
    IPrefixNavigation_lvl_4
{}

public interface IFilesNavigation_lvl_3{
    public IFiles Files(string[] files);   
}