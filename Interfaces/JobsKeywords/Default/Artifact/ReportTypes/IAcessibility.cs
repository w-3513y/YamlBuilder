using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

public interface IAcessibility:
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
    IExpireInNavigation_lvl_2,
    IReportNavigation_lvl_2,
    ICodeQualityNavigation_lvl_3,
    ICoverageReportNavigation_lvl_3,
    IDotEnvNavigation_lvl_3,
    IJUnitNavigation_lvl_3,
    ISastNavigation_lvl_3,
    ISecretSedentionNavigation_lvl_3,
    ITerraformNavigation_lvl_3
{}

public interface IAcessibilityNavigation_lvl_3{
    public IAcessibility Acessibility(string report);
    
}