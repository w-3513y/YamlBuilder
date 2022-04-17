using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface ITimeOut:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface ITimeOutNavigation{
    public ITimeOut TimeOut();
}