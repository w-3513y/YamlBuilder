using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;

public interface IDeploymentTier:
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
    //going down 1 level(s)
{}

public interface IDeploymentTierNavigation{
    public IDeploymentTier DeploymentTier(Enums.Stages stage);   
}