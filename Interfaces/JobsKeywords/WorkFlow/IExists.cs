using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IExists:
    IJobsNavigation_lvl_0
{}

public interface IExistsNavigation_lvl_2{
    public IExists Exists(string condition);
}