using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IWhen:
    IJobsNavigation_lvl_0
{}

public interface IWhenNavigation_lvl_1{
    public IWhen When(Enums.Job when);
}