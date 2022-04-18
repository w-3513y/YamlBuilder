using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;

public interface IVault:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //
    IFileNavigation,
    ISecretNavigation
{}

public interface IVaultNavigation{
    public IVault Vault(string vault);
}