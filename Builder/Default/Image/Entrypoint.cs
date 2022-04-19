using YamlBuilder.Enums;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;

namespace YamlBuilder.Builder.Default.Image;

public class Entrypoint : BaseBuilder, IDefault_Image_EntryPoint
{
    public Entrypoint(string path) : base(path){}

    public IDefault_AfterScript AfterScript(string commands)
    {
        throw new NotImplementedException();
    }

    public IDefault_Artifacts Artifacts()
    {
        throw new NotImplementedException();
    }

    public IDefault_BeforeScript BeforeScript(string commands)
    {
        throw new NotImplementedException();
    }

    public IDefault_Cache Cache()
    {
        throw new NotImplementedException();
    }

    public IInclude Include()
    {
        throw new NotImplementedException();
    }

    public IIncludeShortSintax Include(string? shorterSintax)
    {
        throw new NotImplementedException();
    }

    public IDefault_Interruptible Interruptible(bool interruptible)
    {
        throw new NotImplementedException();
    }

    public IJobs Jobs(string[] stages)
    {
        throw new NotImplementedException();
    }

    public IDefault_Retry Retry(Retry retry)
    {
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Services.IDefault_Services Services()
    {
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Services.IDefault_ServicesShortSyntax Services(string[] commands)
    {
        throw new NotImplementedException();
    }

    public IStages Stages(string[] stages)
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

    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues)
    {
        throw new NotImplementedException();
    }

    public IVariables Variables()
    {
        throw new NotImplementedException();
    }

    public IWorkFlow WorkFlow()
    {
        throw new NotImplementedException();
    }
}