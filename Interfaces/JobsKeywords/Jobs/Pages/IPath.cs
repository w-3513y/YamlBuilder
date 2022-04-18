using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IPath:
    IJobsNavigation,
    //going up 2 level(s)
    IWhenNavigation
{}

public interface IPathNavigation{

    public IPath Paths(string path);
    
}