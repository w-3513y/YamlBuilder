using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;

public interface IWhen:
    //going up 1 level(s)
    IJobsNavigation,
    //going up 1 level(s)
    IIfsNavigation,
    //going down 1 level(s)
    IAllowFailureNavigation
{}

public interface IWhenNavigation{
    public IWhen When(Enums.When when);
}