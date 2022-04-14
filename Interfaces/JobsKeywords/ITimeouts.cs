using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords;

public interface ITimeouts:
    //going up 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation
{}

public interface ITimeOutNavigation{
    public ITimeouts Timeouts(string time);
}