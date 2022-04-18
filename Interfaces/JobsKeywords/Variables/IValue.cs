using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IValue:
    //going up 1 level(s)
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    //going down 1 level(s)
    IDescriptionNavigation_lvl_3,
    //recursive mode that make possible to have more than one project included
    IKeyNavigation_lvl_1
 {}

public interface IValueNavigation_lvl_2{
    public IValue Value(string value);
}