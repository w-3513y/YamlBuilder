using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IDescription:
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    IKeyNavigation_lvl_1
 {}

public interface IDescriptionNavigation_lvl_3{
    public IDescription Description(string description);
}