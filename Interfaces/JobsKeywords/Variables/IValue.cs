using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IValue:
    //going up 1 level(s)
    IWorkFlowNavigation,
    IJobsNavigation,
    //going down 1 level(s)
    IDescriptionNavigation,
    //recursive mode that make possible to have more than one project included
    IKeyNavigation
 {}

public interface IValueNavigation{
    public IValue Value(string value);
}