using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class Interruptible : Default, IDefault_Interruptible
{
    public Interruptible(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(bool interruptible)
        => Utils.WriteFile(_fullPath, $"  interruptible: {interruptible}");
}