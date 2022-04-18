using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface ISecretSedention:
    IJobsNavigation_lvl_0,
    IExpireInNavigation_lvl_2,
    ITerraformNavigation_lvl_3
{}

public interface ISecretSedentionNavigation_lvl_3{
    public ISecretSedention SecretSedention(string report);
}