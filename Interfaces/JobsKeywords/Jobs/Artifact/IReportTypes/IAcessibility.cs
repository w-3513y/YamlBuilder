using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface IAcessibility:
    IJobsNavigation_lvl_0,
    IExpireInNavigation_lvl_2,
    ICodeQualityNavigation_lvl_3,
    ICoverageReportNavigation_lvl_3,
    IDotEnvNavigation_lvl_3,
    IJUnitNavigation_lvl_3,
    ISastNavigation_lvl_3,
    ISecretSedentionNavigation_lvl_3,
    ITerraformNavigation_lvl_3
{}

public interface IAcessibilityNavigation_lvl_3{
    public IAcessibility Acessibility(string report);
    
}