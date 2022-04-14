using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.IIncludes;

public interface IFile:
    //navigation 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    //going up 1 level(s)
    //recursive mode that make possible to have more than one project included
    IProjectNavigation
{}

public interface IFileNavigation{
    public IFile File(string[] files);   
}