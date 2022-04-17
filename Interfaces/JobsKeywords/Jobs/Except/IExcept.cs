using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Except;

public interface IExcept:
    //going down 1 level(s)
    IRefNavigation
{}

public interface IExceptShortSyntax:
    //going up 3 level(s) abouve
    IJobsNavigation

{}

public interface IExceptNavigation{
    public IExcept Except();
    public IExceptShortSyntax Except(string[] exceptions);
}