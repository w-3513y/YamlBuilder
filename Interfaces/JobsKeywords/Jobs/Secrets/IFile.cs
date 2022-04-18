using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;

public interface IFile:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //
    ISecretNavigation
{}

public interface IFileNavigation{
    public IFile File(bool yes);
}