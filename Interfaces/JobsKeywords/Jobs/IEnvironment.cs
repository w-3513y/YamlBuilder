using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IEnvironment:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IEnvironmentNavigation{
    public IEnvironment Environment();
}