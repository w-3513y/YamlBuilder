using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;

namespace YamlBuilder.Builder.Default.Image;

public class Entrypoint : Image, IDefault_Image_EntryPoint
{
    public Entrypoint(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string entrypoint)
        => Utils.WriteFile(_fullPath, $"    entrypoint: [{entrypoint}]");
}