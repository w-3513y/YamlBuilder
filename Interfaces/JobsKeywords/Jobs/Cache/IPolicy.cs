using YamlBuilder.Enums;
using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.ICaches;

public interface IPolicy:    
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    //going up 1 level(s)
    IPathsNavigation,
    IWhenNavigation,
    IUntracked,
    IKeyNavigation
{}


public interface IPolicyNavigation{
    public IPolicy Policy(GitCommand command);   
}