using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IStage:
    //going up 1 level(s)
    IJobsNavigation
{}

public interface IStageNavigation{
    public IStage Stage(string stage);
}
