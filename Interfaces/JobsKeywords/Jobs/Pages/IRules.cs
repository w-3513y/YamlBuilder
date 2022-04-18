using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IRules:
    IIfsNavigation_lvl_3
{}

public interface IRulesNavigation_lvl_2{
    public IRules Rules();
}