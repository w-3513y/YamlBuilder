using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.GitLab;
using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Builder;

public class GitLabYaml : BaseBuilder, IGitLabYaml
{

    #region class methods
    public GitLabYaml(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public static IGitLabYaml Builder(string filePath, IServiceLocator serviceLocator) 
        => new GitLabYaml(filePath, serviceLocator);

    #endregion

    public IDefault Default()
    {
        _serviceLocator.GetService<IDefault>().Build();
        return _serviceLocator.GetService<IDefault>();
    }

    public IIncludeShortSyntax Include(string shorterSyntax)
    {
        _serviceLocator.GetService<IIncludeShortSyntax>().Build(shorterSyntax);
        return _serviceLocator.GetService<IIncludeShortSyntax>();
    }

    public IInclude Include()
    {
        _serviceLocator.GetService<IInclude>().Build();
        return _serviceLocator.GetService<IInclude>();
    }

    public IJobs Job(string jobName)
    {
        Utils.WriteFile(_fullPath, $"{jobName}:");
        throw new NotImplementedException();
    }

    public IStages Stages(string[] stages)
    {
        _serviceLocator.GetService<IStages>().Build(stages);
        return _serviceLocator.GetService<IStages>();
    }

    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues)
    {
        _serviceLocator.GetService<IVariablesShortSyntax>().Build(keyValues);
        return _serviceLocator.GetService<IVariablesShortSyntax>();
    }

    public IVariables Variables()
    {
        _serviceLocator.GetService<IVariables>().Build();
        return _serviceLocator.GetService<IVariables>();
    }

    public IWorkFlow WorkFlow()
    {
        _serviceLocator.GetService<IWorkFlow>().Build();
        return _serviceLocator.GetService<IWorkFlow>();
    }
}