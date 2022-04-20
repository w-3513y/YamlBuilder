using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

public interface IDefault_Artifacts_Report_Acessibility:
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
    IDefault_Artifacts_ExpireIn_Navigation_lvl_2,
    IDefault_Artifacts_Report_Navigation_lvl_2,
    IDefault_Artifacts_Report_CodeQuality_Navigation_lvl_3,
    IDefault_Artifacts_Report_CoverageReport_Navigation_lvl_3,
    IDefault_Artifacts_Report_DotEnv_Navigation_lvl_3,
    IDefault_Artifacts_Report_JUnit_Navigation_lvl_3,
    IDefault_Artifacts_Report_Sast_Navigation_lvl_3,
    IDefault_Artifacts_Report_SecretDetection_Navigation_lvl_3,
    IDefault_Artifacts_Report_Terraform_Navigation_lvl_3
{}

public interface IDefault_Artifacts_Report_Acessibility_Navigation_lvl_3{
    public IDefault_Artifacts_Report_Acessibility Acessibility(string report);
    
}