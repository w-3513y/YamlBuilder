using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface ICodeQuality:
    IJobsNavigation_lvl_0,
    IExpireInNavigation_lvl_2,
    ICoverageReportNavigation_lvl_3,
    IDotEnvNavigation_lvl_3,
    IJUnitNavigation_lvl_3,
    ISastNavigation_lvl_3,
    ISecretSedentionNavigation_lvl_3,
    ITerraformNavigation_lvl_3
{}

public interface ICodeQualityNavigation_lvl_3{
    public ICodeQuality CodeQuality(string report);
    
}