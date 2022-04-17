using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts.IRepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts;

public interface IPaths:
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    //going up 1 level(s)
    IExpireInNavigation,
    IExcludeNavigation,
    IReportNavigation
{}

public interface IPathsNavigation{

    public IPaths Paths(string[] paths);
    
}