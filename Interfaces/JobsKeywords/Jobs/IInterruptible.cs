using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IInterruptible:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IInterruptibleNavigation{
    public IInterruptible Interruptible(bool interruptible);
}