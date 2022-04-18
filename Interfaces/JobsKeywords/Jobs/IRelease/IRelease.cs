using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface IRelease:
    //going up 3 level(s) abouve
    ITagNameNavigation,
    INameNavigation,
    IRefNavigation,
    IMilestonesNavigation,
    IReleasedAt
{}

public interface IReleaseNavigation_lvl_1{
    public IRelease Release();
}