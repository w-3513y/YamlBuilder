using YamlBuilder.Interfaces.JobsKeywords.Default.Image;

namespace YamlBuilder.Builder.Default.Image;

public class Image : BaseBuilder, IDefault_Image
{

    public Image(string path)
        : base(path)
        {}

    public IDefault_Image_EntryPoint Entrypoint()
    {
        Utils.WriteFile(_fullPath, $"    entrypoint:");
        return Utils.InvokeObject<IDefault_Image_EntryPoint>(_fullPath);
    }

    public IDefault_Image_Name Name(string name)
    {
        Utils.WriteFile(_fullPath, $"    name: {name}");
        return Utils.InvokeObject<IDefault_Image_Name>(_fullPath);
    }
}