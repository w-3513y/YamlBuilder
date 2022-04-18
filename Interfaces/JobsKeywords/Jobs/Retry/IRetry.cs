using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;

public interface IRetry:
    IMaxNavigation
{}

public interface IRetryShortSyntax:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IRetryNavigation{
    public IRetry Retry(Enums.Retry retries);
}