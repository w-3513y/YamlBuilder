using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Only;

public interface IOnly:
    //going up 3 level(s) abouve
    IRefNavigation
{}

public interface IOnlyShortSyntax:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IOnlyNavigation{
    public IOnly Only();
    public IOnlyShortSyntax Only(string[] includeds);
}