using YamlBuilder.Interfaces.File;
using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Builder;

public class GitLabYaml : IGitLabYaml
{
    private readonly string _fullPath;

    public GitLabYaml(string filename) 
        => _fullPath = System.Reflection.Assembly.GetExecutingAssembly().Location + filename + ".yml";

    public static IGitLabYaml Builder(string filename) 
        => new GitLabYaml(filename);

    public IDefault Default()
    {
        File.WriteAllText(_fullPath, "default:");
        return this.Default();
    }

    public IInclude Include(string? shorterSintax)
    {
        File.WriteAllText(_fullPath, "include:");
        return this.Include(shorterSintax);
    }

    public IJobs Job(string jobName)
    {
        File.WriteAllText(_fullPath, $"{jobName}:");
        return this.Job(jobName);
    }

    public IStages Stages()
    {
        File.WriteAllText(_fullPath, "stages:");
        return this.Stages();
    }

    public IVariables Variables(Dictionary<string, string>? keyValues)
    {
        File.WriteAllLines(_fullPath, new string[] {"variables:"});
        if (keyValues is not null)
        {
            foreach(var values in keyValues)
            {
                File.WriteAllText(_fullPath, $"  {values.Key}: {values.Value}");
            }
        }
        return this.Variables(keyValues);
    }
}