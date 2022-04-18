using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface IJUnit:
    //going up 5 level(s) abouve
    IJobsNavigation_lvl_0,
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