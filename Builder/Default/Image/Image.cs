using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;

namespace YamlBuilder.Builder.Default.Image;

public class ImageShortSyntax : Default, IDefault_ImageShortSyntax
{
     public ImageShortSyntax(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string image)
        => Utils.WriteFile(_fullPath, $"  image: {image}");
}

public class Image : Default, IDefault_Image
{

    public Image(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public new void Build()
        => Utils.WriteFile(_fullPath, "  image:");

    public IDefault_Image_EntryPoint Entrypoint(string entrypoint)
    {
        _serviceLocator.GetService<IDefault_Image_EntryPoint>().Build(entrypoint);
        return _serviceLocator.GetService<IDefault_Image_EntryPoint>();
    }

    public IDefault_Image_Name Name(string name)
    {
        _serviceLocator.GetService<IDefault_Image_Name>().Build(name);
        return _serviceLocator.GetService<IDefault_Image_Name>();
    }
}