using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IExcept:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IExceptNavigation{
    public IExcept Except();
}