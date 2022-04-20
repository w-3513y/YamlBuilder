namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface IJobs_Artifact_Report:
    IJobs_Artifact_Report_Acessibility_Navigation_lvl_3,
    IJobs_Artifact_Report_CodeQuality_Navigation_lvl_3,
    IJobs_Artifact_Report_CoverageReport_Navigation_lvl_3,
    IJobs_Artifact_Report_DotEnv_Navigation_lvl_3,
    IJobs_Artifact_Report_JUnit_Navigation_lvl_3,
    IJobs_Artifact_Report_Sast_Navigation_lvl_3,
    IJobs_Artifact_Report_SecretSedention_Navigation_lvl_3,
    IJobs_Artifact_Report_Terraform_Navigation_lvl_3
{
    public void Build(string report);
}

public interface IJobs_Artifacts_Report_Navigation_lvl_2{
    public IJobs_Artifact_Report Report();    
}
