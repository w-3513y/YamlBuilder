using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IWhen:
    //going up 4 level(s) abouve
    IJobsNavigation_lvl_0
{}

public interface IWhenNavigation_lvl_1{
    public IWhen When(Enums.Job when);
}