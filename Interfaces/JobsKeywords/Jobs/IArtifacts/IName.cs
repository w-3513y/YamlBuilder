using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts.IRepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts;

public interface IName:
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    //going up 1 level(s)
    IPathsNavigation,
    IExpireInNavigation,
    IExcludeNavigation,
    IExposeAsNavigation,
    IReportNavigation
{}

public interface INameNavigation{

    public IName Name(string name);
    
}
