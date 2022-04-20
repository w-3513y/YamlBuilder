using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class Retry : Default, IDefault_Retry
{
    public Retry(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(Enums.Retry retry)
        => Utils.WriteFile(_fullPath, $"  retry: {retry}");
}