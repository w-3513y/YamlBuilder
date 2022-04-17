using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifact;

public interface IExpireIn:
    //going up 4 level(s) abouve
    IJobsNavigation
    //going up 2 level(s)
{}

public interface IExpireInNavigation{
    public IExpireIn ExpireIn(string date);
}