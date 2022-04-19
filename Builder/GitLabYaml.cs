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
        return Utils.InvokeObject<IDefault>(_fullPath, _serviceLocator);
    }

    public IIncludeShortSyntax Include(string? shorterSyntax)
    {
        Utils.WriteFile(_fullPath, $"include: {shorterSyntax}");
        return Utils.InvokeObject<IIncludeShortSyntax>(_fullPath, _serviceLocator);
    }

    public IInclude Include()
    {
        Utils.WriteFile(_fullPath, $"include:");
        return Utils.InvokeObject<IInclude>(_fullPath, _serviceLocator);
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
        return Utils.InvokeObject<IStages>(_fullPath, _serviceLocator);
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
        return Utils.InvokeObject<IVariablesShortSyntax>(_fullPath, _serviceLocator);
    }

    public IVariables Variables()
    {
        Utils.WriteFile(_fullPath, "variables:");
        return Utils.InvokeObject<IVariables>(_fullPath, _serviceLocator);
    }

    public IWorkFlow WorkFlow()
    {
        Utils.WriteFile(_fullPath, "workflow:");
        throw new NotImplementedException();
    }
}