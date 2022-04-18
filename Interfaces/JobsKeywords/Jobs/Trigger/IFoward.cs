using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IFoward:
    IPipelineVariablesNavigation,
    IYamlVariablesNavigation
{}

public interface IFowardNavigation{
    public IFoward Foward();
}