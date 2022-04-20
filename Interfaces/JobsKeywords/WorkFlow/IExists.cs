using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IWorkFlow_Exists:
    IJobs_Navigation_lvl_0
{
    public void Build(string condition);
}

public interface IWorkFlow_Exists_Navigation_lvl_2{
    public IWorkFlow_Exists Exists(string condition);
}