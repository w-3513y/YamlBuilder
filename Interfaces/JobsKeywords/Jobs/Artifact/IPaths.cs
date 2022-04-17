using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact;

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