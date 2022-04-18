using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IWhen:
    IJobsNavigation_lvl_0,
    IIfsNavigation_lvl_2,
    IAllowFailureNavigation_lvl_3
{}

public interface IWhenNavigation_lvl_3{
    public IWhen When(Enums.When when);
}