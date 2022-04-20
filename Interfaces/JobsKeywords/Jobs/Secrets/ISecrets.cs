using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;

public interface IJobs_Secrets:
    IJobs_Secrets_Secret_Navigation_lvl_2
{
    public void Build();
}

public interface IJobs_Secrets_Navigation_lvl_1{
    public IJobs_Secrets Secrets();
}