using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class Interruptible : Default, IDefault_Interruptible
{
    public Interruptible(string path) : base(path){}
}