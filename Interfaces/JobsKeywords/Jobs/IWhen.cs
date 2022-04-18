using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IWhen:
    //going up 4 level(s) abouve
    IJobsNavigation
    //going up 2 level(s)
    //going up 1 level(s)
{}

public interface IWhenNavigation{
    public IWhen When(Enums.Job when);
}