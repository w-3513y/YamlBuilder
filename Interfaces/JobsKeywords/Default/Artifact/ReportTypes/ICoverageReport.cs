namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

public interface ICoverageReport:
    ICoverageFormatNavigation_lvl_4
{}

public interface ICoverageReportNavigation_lvl_3{
    public ICoverageReport CoverageReport();
}