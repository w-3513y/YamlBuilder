using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface IRef:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IRefNavigation{
    public IRef Ref(string reference);
}