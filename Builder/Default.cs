using YamlBuilder.Enums;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Builder;

public class Default : IDefault
{
    public IAfterScript AfterScript(string commands)
    {
        throw new NotImplementedException();
    }

    public IArtifacts Artifacts()
    {
        throw new NotImplementedException();
    }

    public IBeforeScript BeforeScript(string commands)
    {
        throw new NotImplementedException();
    }

    public ICache Cache()
    {
        throw new NotImplementedException();
    }

    public IImage Image()
    {
        throw new NotImplementedException();
    }

    public IImageShortSintax Image(string image)
    {
        throw new NotImplementedException();
    }

    public IInterruptible Interruptible(bool interruptible)
    {
        throw new NotImplementedException();
    }

    public IRetry Retry(Retry retry)
    {
        throw new NotImplementedException();
    }

    public IServices Services()
    {
        throw new NotImplementedException();
    }

    public IServicesShortSyntax Services(string[] commands)
    {
        throw new NotImplementedException();
    }

    public ITags Tags(string[] tags)
    {
        throw new NotImplementedException();
    }

    public ITimeouts Timeouts(string time)
    {
        throw new NotImplementedException();
    }

    IAfterScript IAfterScriptNavigation.AfterScript(string commands)
    {
        throw new NotImplementedException();
    }

    IBeforeScript IBeforeScriptNavigation.BeforeScript(string commands)
    {
        throw new NotImplementedException();
    }

    IInterruptible IInterruptibleNavigation.Interruptible(bool interruptible)
    {
        throw new NotImplementedException();
    }

    IRetry IRetryNavigation.Retry(Retry retry)
    {
        throw new NotImplementedException();
    }

    ITags ITagsNavigation.Tags(string[] tags)
    {
        throw new NotImplementedException();
    }

    ITimeouts ITimeOutNavigation.Timeouts(string time)
    {
        throw new NotImplementedException();
    }
}