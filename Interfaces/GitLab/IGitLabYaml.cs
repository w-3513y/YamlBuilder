using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.GitLab;

public interface IGitLabYaml{
    public IDefault Default();
    public IInclude Include();
    public IIncludeShortSintax Include(string? shorterSintax);
    public IStages Stages(string[] stages);
    public IVariables Variables();
    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues);
    public IWorkFlow WorkFlow();
    public IJobs Job(string jobName);
}
