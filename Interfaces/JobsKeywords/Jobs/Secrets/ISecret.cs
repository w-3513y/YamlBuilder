using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;

public interface ISecret:
    IVaultNavigation
{}

public interface ISecretNavigation{
    public ISecret Secret();
}