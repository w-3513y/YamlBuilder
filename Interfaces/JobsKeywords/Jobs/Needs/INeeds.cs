using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Needs;

public interface INeeds:
    IJobNavigation
{}

public interface INeedsShortSyntax:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface INeedsNavigation{
    public INeeds Needs();
    public INeedsShortSyntax Needs(string[] dependencies);
}