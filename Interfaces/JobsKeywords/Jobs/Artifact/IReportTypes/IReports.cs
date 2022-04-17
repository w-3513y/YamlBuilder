namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifact.IRepostTypes;

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
