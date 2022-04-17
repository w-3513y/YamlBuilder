using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IPath:
    IJobsNavigation
{}

public interface IPathNavigation{

    public IPath Paths(string path);
    
}