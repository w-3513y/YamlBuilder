using YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IWorkFlow:
    //going down 1 level(s)
    IRulesNavigation
{}

public interface IWorkFlowNavigation{
    public IWorkFlow WorkFlow();
}