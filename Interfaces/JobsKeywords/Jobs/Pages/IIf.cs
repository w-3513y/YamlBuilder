using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IIfs:
    IJobsNavigation,
    //going up 2 level(s)
    IWhenNavigation
{}

public interface IIfsNavigation{
    public IIfs Ifs(string condition);
}