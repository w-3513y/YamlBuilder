using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IYamlVariables:
    IJobsNavigation
{}

public interface IYamlVariablesNavigation{
    public IYamlVariables YamlVariables(bool isYaml);
}