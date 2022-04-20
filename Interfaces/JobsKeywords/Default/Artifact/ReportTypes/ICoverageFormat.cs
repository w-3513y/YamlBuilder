namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

public interface IDefault_Artifacts_Report_CoverageFormat:
    IDefault_Artifacts_Report_Path_Navigation_lvl_5
{
    public void Build(string format);
}

public interface IDefault_Artifacts_Report_CoverageFormat_Navigation_lvl_4{
    public IDefault_Artifacts_Report_CoverageFormat CoverageFormat(string format);
}