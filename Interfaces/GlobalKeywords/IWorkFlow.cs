using YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IWorkFlow:
    //going down 1 level(s)
    IRulesNavigation_lvl_1
{}

public interface IWorkFlowNavigation_lvl_0{
    public IWorkFlow WorkFlow();
}