using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class TimeOut : Default, IDefault_Timeouts
{
    public TimeOut(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string time)
        => Utils.WriteFile(_fullPath, $"  timeouts: {time}");
}