using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Image;

public interface IName:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //going up 1 level(s)
    //going down 1 level(s)
    IEntryPointNavigation
{}

public interface INameNavigation{
    public IName Name(string name);   
}
