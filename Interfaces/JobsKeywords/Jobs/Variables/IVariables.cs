using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Variables;

public interface IJobs_Variables_Variables:
    IJobs_Variables_Key_Navigation_lvl_2
{
    public void Build();
}

public interface IJobs_Variables_ShortSyntax:
    IJobs_Navigation_lvl_0
{
    public void Build(Dictionary<string, string> keyValuePairs);
}

public interface IJobs_Variables_Navigation_lvl_1{
    public IJobs_Variables_ShortSyntax Variables(Dictionary<string, string> keyValuePairs);
    public IJobs_Variables_Variables Variables();
}
