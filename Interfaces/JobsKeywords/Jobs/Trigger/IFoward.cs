using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IFoward:
    IPipelineVariablesNavigation_lvl_3,
    IYamlVariablesNavigation_lvl_3
{}

public interface IFowardNavigation_lvl_2{
    public IFoward Foward();
}