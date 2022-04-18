using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IWhen:
    //going up 4 level(s) abouve
    IJobsNavigation
{}

public interface IWhenNavigation{
    public IWhen When(Enums.Job when);
}