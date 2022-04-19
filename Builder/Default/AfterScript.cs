using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class AfterScript : Default, IDefault_AfterScript
{
    public AfterScript(string path) : base(path){}
}