using YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IWorkFlow:
    IWorkFlow_Rules_Navigation_lvl_1
{}

public interface IWorkFlow_Navigation_lvl_0{
    public IWorkFlow WorkFlow();
}