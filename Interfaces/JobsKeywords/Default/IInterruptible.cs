using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface IDefault_Interruptible:    
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IDefault_Retry_Navigation_lvl_1,
    IDefault_Services_Navigation_lvl_1,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1
{}


public interface IDefault_Interruptible_Navigation_lvl_1{

    public IDefault_Interruptible Interruptible(bool interruptible);
    
}