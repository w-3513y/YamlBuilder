using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts.IRepostTypes;

public interface ISecretSedention:
    //going up 5 level(s) abouve
    IJobsNavigation,
    //going up 3 level(s)
    //going up 2 level(s)
    IExpireInNavigation,
    //going up 1 level(s)
    ITerraformNavigation
{}

public interface ISecretSedentionNavigation{
    public ISecretSedention SecretSedention(string report);
}