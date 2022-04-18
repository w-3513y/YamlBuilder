using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IAllowFailure:
    //going up 1 level(s)
    IJobsNavigation_lvl_0,
    //going up 1 level(s)
    IIfsNavigation_lvl_2
{}

public interface IAllowFailureNavigation_lvl_3{
    public IAllowFailure AllowFailure(bool yes);
}