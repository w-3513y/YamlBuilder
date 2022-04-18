using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IPath:
    IJobsNavigation_lvl_0,
    IWhenNavigation_lvl_1
{}

public interface IPathNavigation_lvl_3{

    public IPath Paths(string path);
    
}