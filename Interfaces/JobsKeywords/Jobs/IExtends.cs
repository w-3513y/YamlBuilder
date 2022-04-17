using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IExtends:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IExtendsNavigation{
    public IExtends Extends();
}