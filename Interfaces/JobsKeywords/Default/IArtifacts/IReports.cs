using YamlBuilder.Interfaces.JobsKeywords.IArtifacts.Default.IRepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.IArtifacts;

public interface IReport:
    //going down 1 level(s)
    IAcessibilityNavigation,
    ICodeQualityNavigation,
    ICoverageReportNavigation,
    IDotEnvNavigation,
    IJUnitNavigation,
    ISastNavigation,
    ISecretSedentionNavigation,
    ITerraformNavigation
{}

public interface IReportNavigation{
    public IReport Report();    
}
