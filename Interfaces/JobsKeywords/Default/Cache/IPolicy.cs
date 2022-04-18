using YamlBuilder.Enums;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Cache;

public interface IPolicy:    
    //going up 4 level(s) abouve
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    IInterruptibleNavigation_lvl_1,
    IRetryNavigation_lvl_1,
    IServicesNavigation_lvl_1,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    //going up 1 level(s)
    IPathsNavigation_lvl_2,
    IWhenNavigation_lvl_2,
    IUntracked,
    IKeyNavigation_lvl_2
{}


public interface IPolicyNavigation_lvl_2{
    public IPolicy Policy(GitCommand command);   
}