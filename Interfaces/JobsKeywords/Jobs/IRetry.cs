using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IRetry:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IRetryNavigation{
    public IRetry Retry();
}