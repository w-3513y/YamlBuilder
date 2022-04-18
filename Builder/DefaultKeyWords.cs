using YamlBuilder.Enums;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Builder;

public abstract class DefaultKeyWords : BaseBuilder, 
    IArtifacts, Interfaces.JobsKeywords.Default.Artifact.IExpireIn,
                Interfaces.JobsKeywords.Default.Artifact.IExclude,
                Interfaces.JobsKeywords.Default.Artifact.IExposeAs
{
    protected DefaultKeyWords(string fullPath) : base(fullPath) {}

    public IBeforeScript BeforeScript(string commands)
    {
        throw new NotImplementedException();
    }

    public ICache Cache()
    {
        return this.Cache();
    }

    public IExclude Exclude(string file)
    {
        return this;
    }

    public IExpireIn ExpireIn(string date)
    {
        return this;
    }

    public IExposeAs ExposeAs(string name)
    {
        return this;
    }

    public IInclude Include()
    {
        throw new NotImplementedException();
    }

    public IIncludeShortSintax Include(string? shorterSintax)
    {
        throw new NotImplementedException();
    }

    public IInterruptible Interruptible(bool interruptible)
    {
        throw new NotImplementedException();
    }

    public IJobs Jobs(string[] stages)
    {
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.IName Name(string name)
    {
        throw new NotImplementedException();
    }

    public Interfaces.JobsKeywords.Default.Artifact.IPaths Paths(string[] paths)
    {
        throw new NotImplementedException();
    }

    public IPublic Public(bool publ)
    {
        throw new NotImplementedException();
    }

    public IReport Report()
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

    public IStages Stages(string[] stages)
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

    public Interfaces.JobsKeywords.Default.Artifact.IUntracked Untracked(bool untracked)
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

    public Interfaces.JobsKeywords.Default.Artifact.IWhen When(JobGlobal when)
    {
        throw new NotImplementedException();
    }

    public IWorkFlow WorkFlow()
    {
        throw new NotImplementedException();
    }
}