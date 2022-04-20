using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Include;

namespace YamlBuilder.Builder.Include;

public class IncludeShortSyntax : GitLabYaml, IIncludeShortSyntax
{
     public IncludeShortSyntax(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string shorterSyntax)
    {
        Utils.WriteFile(_fullPath, $"include: {shorterSyntax}");
    }
}

public class Include : GitLabYaml, IInclude
{

    public Include(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build()
    {
        Utils.WriteFile(_fullPath, $"include:");
    }

    public IInclude_Local Local(string file)
    {
        _serviceLocator.GetService<IInclude_Local>().Build(file);
        return _serviceLocator.GetService<IInclude_Local>();
    }

    public IInclude_Project Project(string project)
    {
        _serviceLocator.GetService<IInclude_Project>().Build(project);
        return _serviceLocator.GetService<IInclude_Project>();
    }

    public IInclude_Remote Remote(string url)
    {
        _serviceLocator.GetService<IInclude_Remote>().Build(url);
        return _serviceLocator.GetService<IInclude_Remote>();
    }

    public IInclude_Template Template(string[] templates)
    {
        _serviceLocator.GetService<IInclude_Template>().Build(templates);
        return _serviceLocator.GetService<IInclude_Template>();
    }
}