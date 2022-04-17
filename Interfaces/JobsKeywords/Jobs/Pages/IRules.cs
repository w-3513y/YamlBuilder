using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IRules:
    IIfsNavigation
{}

public interface IRulesNavigation{
    public IRules Rules();
}