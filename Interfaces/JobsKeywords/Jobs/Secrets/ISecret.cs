using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;

public interface IJobs_Secrets_Secret:
    IJobs_Secrets_Vault_Navigation_lvl_3
{
    public void Build(string secretName);
}

public interface IJobs_Secrets_Secret_Navigation_lvl_2{
    public IJobs_Secrets_Secret Secret(string secretName);
}