using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class BeforeScript : Default, IDefault_BeforeScript
{
    public BeforeScript(string path) : base(path){}
}