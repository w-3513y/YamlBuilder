using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface IDescription:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IDescriptionNavigation{
    public IDescription Description(string description);
}