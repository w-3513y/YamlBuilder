using YamlBuilder.Interfaces.GitLab;
using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Builder;

public class GitLabYaml : BaseBuilder, IGitLabYaml
{

    #region class methods
    public GitLabYaml(string filePath) : base(filePath) {}

    public static IGitLabYaml Builder(string filePath) 
        => new GitLabYaml(filePath);

    #endregion

    public IDefault Default()
    {
        Utils.WriteFile(_fullPath, "default:");
        return Utils.InvokeObject<IDefault>(_fullPath);
    }

    public IIncludeShortSyntax Include(string? shorterSyntax)
    {
        Utils.WriteFile(_fullPath, $"include: {shorterSyntax}");
        return Utils.InvokeObject<IIncludeShortSyntax>(_fullPath);
    }

    public IInclude Include()
    {
        Utils.WriteFile(_fullPath, $"include:");
        return Utils.InvokeObject<IInclude>(_fullPath);
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
        return Utils.InvokeObject<IStages>(_fullPath);
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
        return Utils.InvokeObject<IVariablesShortSyntax>(_fullPath);
    }

    public IVariables Variables()
    {
        Utils.WriteFile(_fullPath, "variables:");
        return Utils.InvokeObject<IVariables>(_fullPath);
    }

    public IWorkFlow WorkFlow()
    {
        Utils.WriteFile(_fullPath, "workflow:");
        throw new NotImplementedException();
    }
}