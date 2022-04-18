using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface IJUnit:
    IJobsNavigation_lvl_0,
    IExpireInNavigation_lvl_2,
    ISastNavigation_lvl_3,
    ISecretSedentionNavigation_lvl_3,
    ITerraformNavigation_lvl_3
{}

public interface IJUnitNavigation_lvl_3{
    public IJUnit JUnit(string report);
}