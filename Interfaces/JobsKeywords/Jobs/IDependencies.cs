using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IDependencies:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IDependenciesNavigation{
    public IDependencies Dependencies(string[] dependencies);
}