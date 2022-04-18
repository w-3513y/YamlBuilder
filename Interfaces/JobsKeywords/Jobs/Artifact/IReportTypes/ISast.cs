using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface ISast:
    IJobsNavigation_lvl_0,
    IExpireInNavigation_lvl_2,
    ISecretSedentionNavigation_lvl_3,
    ITerraformNavigation_lvl_3
{}

public interface ISastNavigation_lvl_3{
    public ISast Sast(string report);
}