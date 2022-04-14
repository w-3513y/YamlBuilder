using YamlBuilder.Enums;
using YamlBuilder.Interfaces.JobsKeywords;
using YamlBuilder.Interfaces.JobsKeywords.IArtifacts;
using YamlBuilder.Interfaces.JobsKeywords.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.IServices;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IDefault {

    public IAfter_Script After_Script(string[] commands);
    public IArtifact Artifacts();
    public IBefore_Script Before_Script(string[] commands);
    public ICache Cache();
    public IImage Image(string name);
    public IInterruptible Interruptible(bool interruptible);
    public IRetry Retry(RetryEnum retry);
    public IServices Services(string[]? commands);
    public ITags Tags(string[] tags);
    public ITimeouts Timeouts(string time);
}