using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;

namespace YamlBuilder.Builder.Default.Image;

public class Name : Image, IDefault_Image_Name
{
    public Name(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}