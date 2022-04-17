using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.ICaches;

public interface IKey:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
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
    IFilesNavigation
{}

public interface IKeyNavigation{
    public IKey Key(string name);
}
