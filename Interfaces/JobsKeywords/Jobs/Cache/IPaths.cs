using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;

public interface IPaths:
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    //going up 1 level(s)
    IWhenNavigation,
    IPolicyNavigation
{}

public interface IPathsNavigation{
    public IPaths Paths(string[] directories);   
}
