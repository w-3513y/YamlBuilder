using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Inherit;

public interface IDefault: 
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
{}

public interface IDefaultNavigation{
    public IDefault Default(string[] commands);
    public IDefault Default(bool yes);
}