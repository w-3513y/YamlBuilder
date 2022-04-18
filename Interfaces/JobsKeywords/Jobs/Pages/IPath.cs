using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IPath:
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    IWhenNavigation_lvl_1
{}

public interface IPathNavigation{

    public IPath Paths(string path);
    
}