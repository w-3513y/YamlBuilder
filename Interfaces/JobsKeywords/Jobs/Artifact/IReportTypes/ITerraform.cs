using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface IJobs_Artifact_Report_Terraform:
    IJobs_Navigation_lvl_0,
    IJobs_Artifacts_ExpireIn_Navigation_lvl_2
{
    public void Build(string report);
}

public interface IJobs_Artifact_Report_Terraform_Navigation_lvl_3{
    public IJobs_Artifact_Report_Terraform Terraform(string report);
}