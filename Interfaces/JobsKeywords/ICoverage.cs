using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords;

public interface ICoverage:
    //going up 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation
{}

public interface ICoverageNavigation{
    public ICoverage Coverage();
}