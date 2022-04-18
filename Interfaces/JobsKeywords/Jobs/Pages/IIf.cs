using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IIfs:
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    IWhenNavigation_lvl_1
{}

public interface IIfsNavigation{
    public IIfs Ifs(string condition);
}