namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface ICoverageReport:
    //going down 1 level(s)
    ICoverageFormatNavigation
{}

public interface ICoverageReportNavigation{
    public ICoverageReport CoverageReport();
}