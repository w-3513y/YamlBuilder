namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

public interface IReport:
    IAcessibilityNavigation_lvl_3,
    ICodeQualityNavigation_lvl_3,
    ICoverageReportNavigation_lvl_3,
    IDotEnvNavigation_lvl_3,
    IJUnitNavigation_lvl_3,
    ISastNavigation_lvl_3,
    ISecretSedentionNavigation_lvl_3,
    ITerraformNavigation_lvl_3
{}

public interface IReportNavigation_lvl_2{
    public IReport Report();    
}
