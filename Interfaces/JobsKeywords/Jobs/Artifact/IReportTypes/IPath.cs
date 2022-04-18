using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface IPath:
    IJobsNavigation_lvl_0,
    IExpireInNavigation_lvl_2,
    IDotEnvNavigation_lvl_3,
    IJUnitNavigation_lvl_3,
    ISastNavigation_lvl_3,
    ISecretSedentionNavigation_lvl_3,
    ITerraformNavigation_lvl_3
{}

public interface IPathNavigation_lvl_5{
    public IPath Path(string path);
}