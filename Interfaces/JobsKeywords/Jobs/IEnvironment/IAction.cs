using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;

public interface IAction:
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
    //going down 1 level(s)
{}

public interface IActionNavigation{
    public IAction Action(Enums.Action action);   
}
