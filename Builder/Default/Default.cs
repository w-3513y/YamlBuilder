using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Builder.Default;

public class Default : GitLabYaml, IDefault
{

    public Default(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build() => Utils.WriteFile(_fullPath, "default:");

    public IDefault_AfterScript AfterScript(string commands)
    {
        Utils.WriteFile(_fullPath, $"  after_script:");
        Utils.WriteFile(_fullPath, $"    - {commands}");
        return _serviceLocator.GetService<IDefault_AfterScript>();
    }

    public IDefault_Artifacts Artifacts()
    {
        _serviceLocator.GetService<IDefault_Artifacts>().Build();
        return _serviceLocator.GetService<IDefault_Artifacts>();
    }

    public IDefault_BeforeScript BeforeScript(string commands)
    {
        Utils.WriteFile(_fullPath, $"  before_script:");
        Utils.WriteFile(_fullPath, $"    - {commands}");

        return _serviceLocator.GetService<IDefault_BeforeScript>();
    }

    public IDefault_Cache Cache()
    {
        Utils.WriteFile(_fullPath, "  cache:");
        return _serviceLocator.GetService<IDefault_Cache>();
    }

    public IDefault_Image Image()
    {
        _serviceLocator.GetService<IDefault_Image>().Build();
        return _serviceLocator.GetService<IDefault_Image>();
    }

    public IDefault_ImageShortSyntax Image(string image)
    {
        _serviceLocator.GetService<IDefault_ImageShortSyntax>().Build(image);
        return _serviceLocator.GetService<IDefault_ImageShortSyntax>();
    }

    public IDefault_Interruptible Interruptible(bool interruptible)
    {
        Utils.WriteFile(_fullPath, $"  interruptible: {interruptible}");
        return _serviceLocator.GetService<IDefault_Interruptible>();
    }

    public IDefault_Retry Retry(Enums.Retry retry)
    {
        Utils.WriteFile(_fullPath, $"  retry: {retry}");
        return _serviceLocator.GetService<IDefault_Retry>();
    }

    public IDefault_Services Services()
    {
        _serviceLocator.GetService<IDefault_Services>().Build();
        return _serviceLocator.GetService<IDefault_Services>();
    }

    public IDefault_ServicesShortSyntax Services(string[] commands)
    {
        _serviceLocator.GetService<IDefault_ServicesShortSyntax>().Build(commands);
        return _serviceLocator.GetService<IDefault_ServicesShortSyntax>();
    }

    public IDefault_Tags Tags(string[] tags)
    {
        Utils.WriteFile(_fullPath, "  tags:");
        foreach(var tag in tags)
        {
            Utils.WriteFile(_fullPath, $"    - {tag}");
        }
        return _serviceLocator.GetService<IDefault_Tags>();
    }

    public IDefault_Timeouts Timeouts(string time)
    {
        Utils.WriteFile(_fullPath, $"  timeouts: {time}");
        return _serviceLocator.GetService<IDefault_Timeouts>();
    }
}