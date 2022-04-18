using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IAllowFailure:
    IJobsNavigation_lvl_0,
    IIfsNavigation_lvl_2
{}

public interface IAllowFailureNavigation_lvl_3{
    public IAllowFailure AllowFailure(bool yes);
}