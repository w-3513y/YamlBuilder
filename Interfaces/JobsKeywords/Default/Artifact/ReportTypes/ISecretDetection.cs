using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

public interface IDefault_Artifacts_Report_SecretDetection:
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
    IDefault_Artifacts_Report_Terraform_Navigation_lvl_3
{
    public void Build(string report);
}

public interface IDefault_Artifacts_Report_SecretDetection_Navigation_lvl_3{
    public IDefault_Artifacts_Report_SecretDetection SecretDetection(string report);
}