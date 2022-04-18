using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IWhen:
    //going up 1 level(s)
    IJobsNavigation_lvl_0,
    //going up 1 level(s)
    IIfsNavigation_lvl_2,
    //going down 1 level(s)
    IAllowFailureNavigation_lvl_3
{}

public interface IWhenNavigation_lvl_3{
    public IWhen When(Enums.When when);
}