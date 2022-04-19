using YamlBuilder.Interfaces.GitLab;
using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Builder;

public class GitLabYaml : BaseBuilder, IGitLabYaml
{

    #region class methods
    public GitLabYaml(string filePath)
        : base(filePath)
        {}

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
        throw new NotImplementedException();
    }

    public IInclude Include()
    {
        Utils.WriteFile(_fullPath, $"include:");
        throw new NotImplementedException();
    }

    public IJobs Job(string jobName)
    {
        Utils.WriteFile(_fullPath, $"{jobName}:");
        throw new NotImplementedException();
    }

    public IStages Stages(string[] stages)
    {
        Utils.WriteFile(_fullPath, "stages:");
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public IVariables Variables()
    {
        Utils.WriteFile(_fullPath, "variables:");
        throw new NotImplementedException();
    }

    public IWorkFlow WorkFlow()
    {
        Utils.WriteFile(_fullPath, "workflow:");
        throw new NotImplementedException();
    }
}