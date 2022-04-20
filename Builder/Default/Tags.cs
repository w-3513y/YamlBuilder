using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Builder.Default;

public class Tags : Default, IDefault_Tags
{
    public Tags(string fullPath, IServiceLocator serviceLocator)
        : base(fullPath, serviceLocator) { }

    public void Build(string[] tags)
    {
        Utils.WriteFile(_fullPath, "  tags:");
        foreach (var tag in tags)
        {
            Utils.WriteFile(_fullPath, $"    - {tag}");
        }
    }
}