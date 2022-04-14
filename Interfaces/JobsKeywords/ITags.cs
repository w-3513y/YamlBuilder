using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords;

public interface ITags:
    //navigation 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    //going up 1 level(s)
    ITimeOutNavigation
 {}

public interface ITagsNavigation{
    public ITags Tags(string[] tags);
}