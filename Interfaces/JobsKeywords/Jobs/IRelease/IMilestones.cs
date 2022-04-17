using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface IMilestones:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IMilestonesNavigation{
    public IMilestones Milestones(string milestones);
}