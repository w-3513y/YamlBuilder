using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords;

public interface ITimeouts:
    //navigation 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation
{}

public interface ITimeOutNavigation{
    public ITimeouts Timeouts(string time);
}