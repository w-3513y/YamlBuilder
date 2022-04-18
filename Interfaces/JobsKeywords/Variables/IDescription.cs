using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IDescription:
    //going up 1 level(s)
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    //recursive mode that make possible to have more than one project included
    IKeyNavigation_lvl_1
 {}

public interface IDescriptionNavigation_lvl_3{
    public IDescription Description(string description);
}