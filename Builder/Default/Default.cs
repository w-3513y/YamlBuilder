using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Builder.Default;

public class Default : GitLabYaml, IDefault
{

    public Default(string path)
        : base(path)
        {}

    public IDefault_AfterScript AfterScript(string commands)
    {
        Utils.WriteFile(_fullPath, $"  after_script: {commands}");
        return Utils.InvokeObject<IDefault_AfterScript>(_fullPath);
    }

    public IDefault_Artifacts Artifacts()
    {
        Utils.WriteFile(_fullPath, "  artifacts:");
        return Utils.InvokeObject<IDefault_Artifacts>(_fullPath);
    }

    public IDefault_BeforeScript BeforeScript(string commands)
    {
        Utils.WriteFile(_fullPath, $"  before_script: {commands}");
        return Utils.InvokeObject<IDefault_BeforeScript>(_fullPath);
    }

    public IDefault_Cache Cache()
    {
        Utils.WriteFile(_fullPath, "  cache:");
        return Utils.InvokeObject<IDefault_Cache>(_fullPath);
    }

    public IDefault_Image Image()
    {
        Utils.WriteFile(_fullPath, "  image:");
        return Utils.InvokeObject<IDefault_Image>(_fullPath);
    }

    public IDefault_ImageShortSyntax Image(string image)
    {
        Utils.WriteFile(_fullPath, $"  image: {image}");
        return Utils.InvokeObject<IDefault_ImageShortSyntax>(_fullPath);
    }

    public IDefault_Interruptible Interruptible(bool interruptible)
    {
        Utils.WriteFile(_fullPath, $"  interruptible: {interruptible}");
        return Utils.InvokeObject<IDefault_Interruptible>(_fullPath);
    }

    public IDefault_Retry Retry(Enums.Retry retry)
    {
        Utils.WriteFile(_fullPath, $"  retry: {retry}");
        return Utils.InvokeObject<IDefault_Retry>(_fullPath);
    }

    public IDefault_Services Services()
    {
        Utils.WriteFile(_fullPath, "  services:");
        return Utils.InvokeObject<IDefault_Services>(_fullPath);
    }

    public IDefault_ServicesShortSyntax Services(string[] commands)
    {
        Utils.WriteFile(_fullPath, "  services:");
        if (commands is not null)
        {
            foreach(var command in commands)
            {
                Utils.WriteFile(_fullPath, $"    - {command}");
            }
        }
        return Utils.InvokeObject<IDefault_ServicesShortSyntax>(_fullPath);
    }

    public IDefault_Tags Tags(string[] tags)
    {
        throw new NotImplementedException();
    }

    public IDefault_Timeouts Timeouts(string time)
    {
        throw new NotImplementedException();
    }
}