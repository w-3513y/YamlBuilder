using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IIfs:
    IJobsNavigation_lvl_0,
    IWhenNavigation_lvl_1
{}

public interface IIfsNavigation_lvl_3{
    public IIfs Ifs(string condition);
}