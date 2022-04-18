using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;

public interface IExists:
    //going up 1 level(s)
    IJobsNavigation
{}

public interface IExistsNavigation{
    public IExists Exists(string condition);
}