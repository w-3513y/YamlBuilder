using YamlBuilder.Interfaces.GitLab;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;

namespace YamlBuilder.Builder;

public class GitLabYaml : BaseBuilder, IGitLabYaml, 
    IDefault, IArtifacts
{
    #region class methods
    public GitLabYaml(string filename) : base(System.Reflection.Assembly.GetExecutingAssembly().Location + filename + ".yml")
        {}

    public static IGitLabYaml Builder(string filename) 
        => new GitLabYaml(filename);

    #endregion

    #region Build methods
    public Interfaces.GlobalKeywords.IDefault Default()
    {
        Utils.WriteFile(_fullPath, "default:");
        return this;
    }

    public Interfaces.GlobalKeywords.IInclude Include(string? shorterSintax)
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

    #region Default methods
        public Interfaces.JobsKeywords.Default.IAfterScript AfterScript(string commands)
    {
        Utils.WriteFile(_fullPath, "  after_script:");
        Utils.WriteFile(_fullPath, $"   - {commands}");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.IArtifacts Artifacts()
    {
        Utils.WriteFile(_fullPath, "  artifacts:");
        return this;
    }

    public Interfaces.JobsKeywords.Default.IBeforeScript BeforeScript(string commands)
    {
        Utils.WriteFile(_fullPath, "  before_script:");
        Utils.WriteFile(_fullPath, $"   - {commands}");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Cache.ICache Cache()
    {
        Utils.WriteFile(_fullPath, "  cache:");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Image.IImage Image()
    {
        Utils.WriteFile(_fullPath, "  image:");
        throw new NotImplementedException();    }

    public Interfaces.JobsKeywords.Default.Image.IImageShortSintax Image(string image)
    {
        Utils.WriteFile(_fullPath, $"  image: {image}");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.IInterruptible Interruptible(bool interruptible)
    {
        Utils.WriteFile(_fullPath, $"  interruptible: {(interruptible? "true" : "false")}");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.IRetry Retry(Enums.Retry retry)
    {
        Utils.WriteFile(_fullPath, $"  retry: {retry}");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Services.IServices Services()
    {
        Utils.WriteFile(_fullPath, "  services:");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Services.IServicesShortSyntax Services(string[] commands)
    {
        Utils.WriteFile(_fullPath, "  services:");
        if (commands is not null)
        {
            foreach(var command in commands)
            {
                Utils.WriteFile(_fullPath, $"    - {command}");
            }
        }
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.ITags Tags(string[] tags)
    {
        Utils.WriteFile(_fullPath, "  tags:");
        if (tags is not null)
        {
            foreach(var tag in tags)
            {
                Utils.WriteFile(_fullPath, $"    - {tag}");
            }
        }
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.ITimeouts Timeouts(string time)
    {
        Utils.WriteFile(_fullPath, $"  timeout: {time}");
        throw new NotImplementedException();
    }

    #endregion

    #region Default.Artifacts methods
    public Interfaces.JobsKeywords.Default.Artifact.IExclude Exclude(string file)
    {
        Utils.WriteFile(_fullPath, "    exclude:");
        Utils.WriteFile(_fullPath, $"      - {file}");
        return this.Exclude(file);
    }

    public Interfaces.JobsKeywords.Default.Artifact.IExpireIn ExpireIn(string date)
    {
        Utils.WriteFile(_fullPath, $"    expire_in: {date}");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.IExposeAs ExposeAs(string name)
    {
        Utils.WriteFile(_fullPath, $"    expose_as: {name}");        
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.IName Name(string name)
    {
        Utils.WriteFile(_fullPath, $"    name: {name}");        
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.IPaths Paths(string[] paths)
    {
        Utils.WriteFile(_fullPath, "    paths:");
        if (paths is not null)
        {
            foreach(var path in paths)
            {
                Utils.WriteFile(_fullPath, $"    - {path}");
            }
        }
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.IPublic Public(bool publ)
    {
        Utils.WriteFile(_fullPath, $"    public: {(publ ? "true" : "false")}");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.RepostTypes.IReport Report()
    {
        Utils.WriteFile(_fullPath, "    report:");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.IUntracked Untracked(bool untracked)
    {
        Utils.WriteFile(_fullPath, $"    untracked: {(untracked ? "true" : "false")}");
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.IWhen When(Enums.JobGlobal when)
    {
        Utils.WriteFile(_fullPath, $"    when: {when}");
        throw new NotImplementedException();
    }
    #endregion
}