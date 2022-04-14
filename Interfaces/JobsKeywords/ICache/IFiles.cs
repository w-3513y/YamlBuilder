using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.ICaches;

public interface IFiles:
    //navigation 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    //going up 2 level(s)
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 1 level(s)
    IPathsNavigation,
    IWhenNavigation,
    IPolicyNavigation,
    IUntracked,
    //going down 1 level(s)
    IPrefixNavigation
{}

public interface IFilesNavigation{
    public IFiles Files(string[] files);   
}