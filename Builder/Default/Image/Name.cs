using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;

namespace YamlBuilder.Builder.Default.Image;

public class Name : Image, IDefault_Image_Name
{
    public Name(string path) : base(path){}
}