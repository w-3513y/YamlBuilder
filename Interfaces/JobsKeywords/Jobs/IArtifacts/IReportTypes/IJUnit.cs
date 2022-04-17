using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts.IRepostTypes;

public interface IJUnit:
    //going up 5 level(s) abouve
    IJobsNavigation,
    //going up 3 level(s)
    //going up 2 level(s)
    IExpireInNavigation,
    //going up 1 level(s)
    ISastNavigation,
    ISecretSedentionNavigation,
    ITerraformNavigation
{}

public interface IJUnitNavigation{
    public IJUnit JUnit(string report);
}