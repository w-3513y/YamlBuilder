using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface IInterruptible:    
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    IRetryNavigation_lvl_1,
    IServicesNavigation_lvl_1,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1
{}


public interface IInterruptibleNavigation_lvl_1{

    public IInterruptible Interruptible(bool interruptible);
    
}