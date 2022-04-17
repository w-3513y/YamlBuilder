using YamlBuilder.Interfaces.JobsKeywords.Include;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IInclude:
    //going down 1 level(s)
    ILocalNavigation,
    IProjectNavigation,
    IRemoteNavigation,
    ITemplateNavigation
{}

public interface IIncludeShortSintax
{}

public interface IIncludeNavigation{
    public IInclude Include();
    public IIncludeShortSintax Include(string? shorterSintax);
}
