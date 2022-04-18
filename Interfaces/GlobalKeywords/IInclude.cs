using YamlBuilder.Interfaces.JobsKeywords.Include;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IInclude:
    ILocalNavigation_lvl_1,
    IProjectNavigation_lvl_1,
    IRemoteNavigation_lvl_1,
    ITemplateNavigation_lvl_1
{}

public interface IIncludeShortSintax
{}

public interface IIncludeNavigation_lvl_0{
    public IInclude Include();
    public IIncludeShortSintax Include(string? shorterSintax);
}
