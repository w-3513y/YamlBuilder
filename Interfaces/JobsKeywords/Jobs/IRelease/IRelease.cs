using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface IRelease:
    ITagNameNavigation_lvl_2,
    INameNavigation_lvl_2,
    IRefNavigation_lvl_2,
    IMilestonesNavigation_lvl_2,
    IReleasedAt_lvl_2
{}

public interface IReleaseNavigation_lvl_1{
    public IRelease Release();
}