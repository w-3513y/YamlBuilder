using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;

namespace YamlBuilder.Builder.Default.Image;

public class ImageShortSyntax : Default, IDefault_ImageShortSyntax
{
     public ImageShortSyntax(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Image : Default, IDefault_Image
{

    public Image(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IDefault_Image_EntryPoint Entrypoint(string entrypoint)
    {
        Utils.WriteFile(_fullPath, $"    entrypoint: [{entrypoint}]");
        return _serviceLocator.GetService<IDefault_Image_EntryPoint>();
    }

    public IDefault_Image_Name Name(string name)
    {
        Utils.WriteFile(_fullPath, $"    name: {name}");
        return _serviceLocator.GetService<IDefault_Image_Name>();
    }
}