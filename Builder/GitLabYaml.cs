using YamlBuilder.Interfaces.GitLab;
using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Builder;

public class GitLabYaml : BaseBuilder, IGitLabYaml
{

    #region class methods
    public GitLabYaml(string filename)
        : base(System.Reflection.Assembly.GetExecutingAssembly().Location + filename + ".yml")
        {}

    public static IGitLabYaml Builder(string filename) 
        => new GitLabYaml(filename);

    #endregion

    #region Build methods
    public IDefault Default()
    {
        Utils.WriteFile(_fullPath, "default:");
        return Utils.InvokeObject<IDefault>(_fullPath);
    }

    public IInclude Include(string? shorterSintax)
    {
        Utils.WriteFile(_fullPath, $"include: {shorterSintax}");
        throw new NotImplementedException();
    }

    public Interfaces.GlobalKeywords.IJobs Job(string jobName)
    {
        Utils.WriteFile(_fullPath, $"{jobName}:");
        throw new NotImplementedException();
    }

    public Interfaces.GlobalKeywords.IStages Stages()
    {
        Utils.WriteFile(_fullPath, "stages:");
        throw new NotImplementedException();
    }

    public Interfaces.GlobalKeywords.IVariables Variables(Dictionary<string, string> keyValues)
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

    public Interfaces.GlobalKeywords.IWorkFlow WorkFlow()
    {
        Utils.WriteFile(_fullPath, "workflow:");
        throw new NotImplementedException();
    }

    #endregion
}