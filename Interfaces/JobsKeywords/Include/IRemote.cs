using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IInclude_Remote:
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0
{
    public void Build(string url);
}

public interface IInclude_Remote_Navigation_lvl_1{
    public IInclude_Remote Remote(string url);   
}