using YamlBuilder.Interfaces.JobsKeywords.Default.Image;

namespace YamlBuilder.Builder.Default.Image;

public class Entrypoint : Image, IDefault_Image_EntryPoint
{
    public Entrypoint(string path) : base(path){}
}