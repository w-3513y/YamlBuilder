using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class TimeOut : Default, IDefault_Timeouts
{
    public TimeOut(string path) : base(path){}
}