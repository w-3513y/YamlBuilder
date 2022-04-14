using YamlBuilder.Interfaces.File;
using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Implementations;

public class GitLabYaml : IGitLabYaml
{
    public GitLabYaml()
    {
    }

    public static IGitLabYaml Builder()
    {
        return new GitLabYaml();
    }

    public IDefault Default()
    {
        return this.Default();
    }

    public IInclude Include(string? shorterSintax)
    {
        return this.Include(shorterSintax);
    }

    public IStages Stages()
    {
        return this.Stages();
    }
}