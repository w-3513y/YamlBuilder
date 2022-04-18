using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;

public interface IWhen:
    IJobsNavigation
{}

public interface IWhenNavigation{
    public IWhen IWhen(string[] options);
}