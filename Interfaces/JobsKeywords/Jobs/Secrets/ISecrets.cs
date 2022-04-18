using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;

public interface ISecrets:
    //going up 3 level(s) abouve
    ISecretNavigation
{}

public interface ISecretsNavigation_lvl_1{
    public ISecrets Secrets();
}