using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;

public interface ISecrets:
    ISecretNavigation_lvl_2
{}

public interface ISecretsNavigation_lvl_1{
    public ISecrets Secrets();
}