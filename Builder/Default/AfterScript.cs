using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class AfterScript : Default, IDefault_AfterScript
{
    public AfterScript(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

}