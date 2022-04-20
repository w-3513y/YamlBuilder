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
        Utils.WriteFile(_fullPath, "default:");
        return _serviceLocator.GetService<IDefault>();
    }

    public IIncludeShortSyntax Include(string? shorterSyntax)
    {
        Utils.WriteFile(_fullPath, $"include: {shorterSyntax}");
        return _serviceLocator.GetService<IIncludeShortSyntax>();
    }

    public IInclude Include()
    {
        Utils.WriteFile(_fullPath, $"include:");
        return _serviceLocator.GetService<IInclude>();
    }

    public IJobs Job(string jobName)
    {
        Utils.WriteFile(_fullPath, $"{jobName}:");
        throw new NotImplementedException();
    }

    public IStages Stages(string[] stages)
    {
        Utils.WriteFile(_fullPath, $"stages:");
        foreach (var stage in stages)
        {
            Utils.WriteFile(_fullPath, $"  - {stage}");
        }
        return _serviceLocator.GetService<IStages>();
    }

    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues)
    {
        Utils.WriteFile(_fullPath, "variables:");
        if (keyValues is not null)
        {
            foreach(var values in keyValues)
            {
                Utils.WriteFile(_fullPath, $"  {values.Key}: {values.Value}");
            }
        }
        return _serviceLocator.GetService<IVariablesShortSyntax>();
    }

    public IVariables Variables()
    {
        Utils.WriteFile(_fullPath, "variables:");
        return _serviceLocator.GetService<IVariables>();
    }

    public IWorkFlow WorkFlow()
    {
        Utils.WriteFile(_fullPath, "workflow:");
        throw new NotImplementedException();
    }
}