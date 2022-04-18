using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.GitLab;

public interface IGitLabYaml{
    public IDefault Default();
    public IInclude Include(string? shorterSintax);
    public IStages Stages();
    public IVariables Variables(Dictionary<string, string> keyValues);
    public IWorkFlow WorkFlow();
    public IJobs Job(string jobName);
}
