using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IVariables:
    IVariables_Key_Navigation_lvl_1
{
    public void Build();
}

public interface IVariablesShortSyntax:
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0
{
    public void Build(Dictionary<string, string> keyValuePairs);
}

public interface IVariables_Navigation_lvl_0{
    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues);
    public IVariables Variables();
}
