using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default.Image;

public class Name : BaseBuilder, YamlBuilder.Interfaces.JobsKeywords.Default.Image.IDefault_Image_Name
{
    public Name(string path) : base(path){}

    public IDefault_AfterScript AfterScript(string commands)
    {
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.IDefault_Artifacts Artifacts()
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

    public Interfaces.JobsKeywords.Default.Image.IDefault_Image_EntryPoint Entrypoint()
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

    public IDefault_Retry Retry(Enums.Retry retry)
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