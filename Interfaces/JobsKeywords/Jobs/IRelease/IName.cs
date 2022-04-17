using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface IName:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface INameNavigation{
    public IName Name(string name);
}