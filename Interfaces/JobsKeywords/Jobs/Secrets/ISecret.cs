using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;

public interface ISecret:
    IVaultNavigation_lvl_3
{}

public interface ISecretNavigation_lvl_2{
    public ISecret Secret();
}