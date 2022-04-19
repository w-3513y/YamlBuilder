using YamlBuilder.Interfaces.JobsKeywords.Include;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IInclude:
    IInclude_Local_Navigation_lvl_1,
    IInclude_Project_Navigation_lvl_1,
    IInclude_Remote_Navigation_lvl_1,
    IInclude_Template_Navigation_lvl_1
{}

public interface IIncludeShortSyntax
{}

public interface IInclude_Navigation_lvl_0{
    public IInclude Include();
    public IIncludeShortSyntax Include(string? shorterSyntax);
}
