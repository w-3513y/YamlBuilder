using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class Retry : Default, IDefault_Retry
{
    public Retry(string path) : base(path){}
}