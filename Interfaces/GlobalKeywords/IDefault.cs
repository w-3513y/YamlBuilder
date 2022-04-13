using YamlBuilder.Enums;
using YamlBuilder.Interfaces.JobsKeywords;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IDefault{

    public IAfter_Script After_Script(string[] commands);
    public IArtifacts Artifacts();
    public IBefore_Script Before_Script(string[] commands);
    public ICache Cache();
    public IImage Image(string name);
    public IInterruptible Interruptible(bool interruptible);
    public IRetry Retry(RetryEnum retry);
    


}
