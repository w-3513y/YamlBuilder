using YamlBuilder.Interfaces.File;
using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Builder;

public class GitLabYaml : IGitLabYaml
{
    public GitLabYaml()
    {
    }

    public static IGitLabYaml Builder(string filename)
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

    public IJobs Job(string jobName)
    {
        throw new NotImplementedException();
    }

    public IStages Stages()
    {
        return this.Stages();
    }

    public IVariables Variables(Dictionary<string, string> keyValues)
    {
        return this.Variables(keyValues);
    }
}