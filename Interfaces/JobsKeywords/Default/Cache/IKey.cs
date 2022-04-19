using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Cache;

public interface IDefault_Cache_Key:
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IDefault_Interruptible_Navigation_lvl_1,
    IDefault_Retry_Navigation_lvl_1,
    IDefault_Services_Navigation_lvl_1,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1,
    IDefault_Cache_Paths_Navigation_lvl_2,
    IDefault_Cache_When_Navigation_lvl_2,
    IDefault_Cache_Policy_Navigation_lvl_2,
    IDefault_Cache_Untracked_Navigation_lvl_2,
    IDefault_Cache_Files_Navigation_lvl_3
{}

public interface IDefault_Cache_Key_Navigation_lvl_2{
    public IDefault_Cache_Key Key(string name);
}
