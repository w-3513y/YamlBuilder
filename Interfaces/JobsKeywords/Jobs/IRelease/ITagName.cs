using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface ITagName:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //
    IDescriptionNavigation,
    IMilestonesNavigation
{}

public interface ITagNameNavigation{
    public ITagName TagName(string tagName);
}