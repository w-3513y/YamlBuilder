using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifact.IRepostTypes;

public interface ICodeQuality:
    //going up 5 level(s) abouve
    IJobsNavigation,
    //going up 3 level(s)
    //going up 2 level(s)
    IExpireInNavigation,
    //going up 1 level(s)
    ICoverageReportNavigation,
    IDotEnvNavigation,
    IJUnitNavigation,
    ISastNavigation,
    ISecretSedentionNavigation,
    ITerraformNavigation
{}

public interface ICodeQualityNavigation{
    public ICodeQuality CodeQuality(string report);
    
}