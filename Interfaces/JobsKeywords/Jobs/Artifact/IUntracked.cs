using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifact.IRepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifact;

public interface IUntracked:
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    //going up 1 level(s)
    INameNavigation,
    IPathsNavigation,
    IExpireInNavigation,
    IExcludeNavigation,
    IExposeAsNavigation,
    IReportNavigation,
    IWhenNavigation
{}


public interface IUntrackedNavigation{
    public IUntracked Untracked(bool untracked);
}