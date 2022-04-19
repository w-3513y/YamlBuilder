using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface IDefault_AfterScript: 
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IIDefault_Artifacts_Artifacts_Navigation_lvl_1,
    IDefault_BeforeScript_Navigation_lvl_1,
    IDefault_Cache_Navigation_lvl_1,
    IDefault_Interruptible_Navigation_lvl_1,
    IDefault_Retry_Navigation_lvl_1,
    IDefault_Services_Navigation_lvl_1,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1
{}

public interface IDefault_AfterScript_Navigation_lvl_1{
    public IDefault_AfterScript AfterScript(string commands);
}