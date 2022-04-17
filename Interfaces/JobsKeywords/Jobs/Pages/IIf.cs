using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IIfs:
    IJobsNavigation
{}

public interface IIfsNavigation{
    public IIfs Ifs(string condition);
}