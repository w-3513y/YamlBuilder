using YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IWorkFlow:
    IRulesNavigation_lvl_1
{}

public interface IWorkFlowNavigation_lvl_0{
    public IWorkFlow WorkFlow();
}