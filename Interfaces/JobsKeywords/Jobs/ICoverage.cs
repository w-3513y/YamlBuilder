using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface ICoverage:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface ICoverageNavigation{
    public ICoverage Coverage();
}