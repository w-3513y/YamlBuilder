using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IPages:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IPagesNavigation{
    public IPages Pages();
}