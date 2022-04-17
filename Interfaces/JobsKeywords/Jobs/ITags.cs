using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface ITags:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface ITagsNavigation{
    public ITags Tags();
}