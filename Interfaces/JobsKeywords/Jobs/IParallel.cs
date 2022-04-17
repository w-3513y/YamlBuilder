using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IParallel:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IParallelNavigation{
    public IParallel Parallel(int multipleTimes);
}