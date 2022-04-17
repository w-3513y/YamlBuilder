using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Image;

public interface IEntryPoint:
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
{}

public interface IEntryPointNavigation{
    public IEntryPoint Entrypoint();   
}