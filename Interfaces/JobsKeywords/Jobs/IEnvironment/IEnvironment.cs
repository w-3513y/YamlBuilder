using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;

public interface IEnvironment:
    //going down 1 level(s)
    INameNavigation
{}
public interface IEnvironmentShortSintax:
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
{}

public interface IEnvironmentNavigation{
    public IEnvironment Environment();
    public IEnvironmentShortSintax Environment(string environment);
}