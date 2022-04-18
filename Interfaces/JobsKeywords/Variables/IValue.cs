using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IValue:
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    IDescriptionNavigation_lvl_3,
    IKeyNavigation_lvl_1
 {}

public interface IValueNavigation_lvl_2{
    public IValue Value(string value);
}