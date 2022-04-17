using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;

public interface IWhen:
    //going up 4 level(s) abouve
    IJobsNavigation
    //going up 2 level(s)
{}

public interface IWhenNavigation{
    public IWhen When(Enums.Job when);   
}