using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IAfterScript: 
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
{}

public interface IAfterScriptNavigation{
    public IAfterScript AfterScript(string commands);
}