using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.File;

public interface IGitLabYaml{
    public IDefault Default();
    public IInclude Include(string? shorterSintax);
    public IStages Stages();
}
