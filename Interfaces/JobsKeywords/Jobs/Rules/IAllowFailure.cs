using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;

public interface IAllowFailure:
    //going up 1 level(s)
    IJobsNavigation,
    //going up 1 level(s)
    IIfsNavigation
{}

public interface IAllowFailureNavigation{
    public IAllowFailure AllowFailure(bool yes);
}