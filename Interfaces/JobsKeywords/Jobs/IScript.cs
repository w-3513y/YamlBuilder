using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IScript:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IScriptNavigation{
    public IScript Script();
}