using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface ISecrets:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface ISecretsNavigation{
    public ISecrets Secrets();
}