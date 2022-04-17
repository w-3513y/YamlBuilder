using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts.IRepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts;

public interface IPublic:
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
    IUntrackedNavigation,
    IWhenNavigation
{}

public interface IPublicNavigation{
    public IPublic Public(bool publ);
}
