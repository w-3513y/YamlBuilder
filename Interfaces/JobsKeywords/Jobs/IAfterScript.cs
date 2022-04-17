using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IAfter_Script: 
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
{}

public interface IAfter_ScriptNavigation{
    public IAfter_Script After_Script(string[] commands);
}