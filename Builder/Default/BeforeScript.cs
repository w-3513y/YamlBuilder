using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class BeforeScript : Default, IDefault_BeforeScript
{
    public BeforeScript(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}