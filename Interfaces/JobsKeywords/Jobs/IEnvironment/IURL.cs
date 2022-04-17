using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;

public interface IURL:
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
    //going down 1 level(s)
{}

public interface IURLNavigation{
    public IURL URL(string url);   
}
