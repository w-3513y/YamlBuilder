namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

public interface IDefault_Artifacts_Report_Report:
    IDefault_Artifacts_Report_Acessibility_Navigation_lvl_3,
    IDefault_Artifacts_Report_CodeQuality_Navigation_lvl_3,
    IDefault_Artifacts_Report_CoverageReport_Navigation_lvl_3,
    IDefault_Artifacts_Report_DotEnv_Navigation_lvl_3,
    IDefault_Artifacts_Report_JUnit_Navigation_lvl_3,
    IDefault_Artifacts_Report_Sast_Navigation_lvl_3,
    IDefault_Artifacts_Report_SecretSedention_Navigation_lvl_3,
    IDefault_Artifacts_Report_Terraform_Navigation_lvl_3
{}

public interface IDefault_Artifacts_Report_Navigation_lvl_2{
    public IDefault_Artifacts_Report_Report Report();    
}
