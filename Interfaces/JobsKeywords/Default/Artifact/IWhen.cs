using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;

public interface IDefault_Artifacts_When:
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IDefault_Cache_Navigation_lvl_1,
    IDefault_Interruptible_Navigation_lvl_1,
    IDefault_Retry_Navigation_lvl_1,
    IDefault_Services_Navigation_lvl_1,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1,
    IDefault_Artifacts_Name_Navigation_lvl_2,
    IDefault_Artifacts_Paths_Navigation_lvl_2,
    IDefault_Artifacts_ExpireIn_Navigation_lvl_2,
    IDefault_Artifacts_Exclude_Navigation_lvl_2,
    IDefault_Artifacts_ExposeAs_Navigation_lvl_2,
    IDefault_Artifacts_Report_Navigation_lvl_2
{}

public interface IDefault_Artifacts_When_Navigation_lvl_2{
    public IDefault_Artifacts_When When(Enums.JobGlobal when);
}