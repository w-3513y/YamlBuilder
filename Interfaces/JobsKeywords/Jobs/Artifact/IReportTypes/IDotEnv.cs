using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface IDotEnv:
    IJobsNavigation_lvl_0,
    IExpireInNavigation_lvl_2,
    IJUnitNavigation_lvl_3,
    ISastNavigation_lvl_3,
    ISecretSedentionNavigation_lvl_3,
    ITerraformNavigation_lvl_3
{}

public interface IDotEnvNavigation_lvl_3{
    public IDotEnv DotEnv(string report);
}