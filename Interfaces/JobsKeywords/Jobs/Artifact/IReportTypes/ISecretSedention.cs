using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface IJobs_Artifact_Report_SecretSedention:
    IJobs_Navigation_lvl_0,
    IJobs_Artifacts_ExpireIn_Navigation_lvl_2,
    IJobs_Artifact_Report_Terraform_Navigation_lvl_3
{}

public interface IJobs_Artifact_Report_SecretSedention_Navigation_lvl_3{
    public IJobs_Artifact_Report_SecretSedention SecretSedention(string report);
}