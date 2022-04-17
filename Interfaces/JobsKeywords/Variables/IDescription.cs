using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IDescription:
    //going up 1 level(s)
    IWorkFlowNavigation,
    IJobsNavigation,
    //recursive mode that make possible to have more than one project included
    IKeyNavigation
 {}

public interface IDescriptionNavigation{
    public IDescription Description(string description);
}