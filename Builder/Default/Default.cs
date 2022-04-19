using YamlBuilder.Enums;
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
        throw new NotImplementedException();
    }

    public IDefault_Image Image()
    {
        Utils.WriteFile(_fullPath, "  image:");
        return Utils.InvokeObject<IDefault_Image>(_fullPath);
    }

    public IDefault_ImageShortSintax Image(string image)
    {
        Utils.WriteFile(_fullPath, $"  image: {image}");
        return Utils.InvokeObject<IDefault_ImageShortSintax>(_fullPath);
    }

    public IDefault_Interruptible Interruptible(bool interruptible)
    {
        throw new NotImplementedException();
    }

    public IDefault_Retry Retry(Retry retry)
    {
        throw new NotImplementedException();
    }

    public IDefault_Services Services()
    {
        throw new NotImplementedException();
    }

    public IDefault_ServicesShortSyntax Services(string[] commands)
    {
        throw new NotImplementedException();
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