namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts.IRepostTypes;

public interface ICoverageReport:
    //going down 1 level(s)
    ICoverageFormatNavigation
{}

public interface ICoverageReportNavigation{
    public ICoverageReport CoverageReport();
}