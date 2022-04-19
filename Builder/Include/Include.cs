using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Include;

namespace YamlBuilder.Builder.Include;

public class IncludeShortSyntax : GitLabYaml, IIncludeShortSyntax
{
     public IncludeShortSyntax(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Include : GitLabYaml, IInclude
{

    public Include(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IInclude_Local Local(string file)
    {
        Utils.WriteFile(_fullPath, $"  - local: {file}");
        return Utils.InvokeObject<IInclude_Local>(_fullPath, _serviceLocator);
    }

    public IInclude_Project Project(string project)
    {
        Utils.WriteFile(_fullPath, $"  - project: {project}");
        return Utils.InvokeObject<IInclude_Project>(_fullPath, _serviceLocator);
    }

    public IInclude_Remote Remote(string url)
    {
        Utils.WriteFile(_fullPath, $"  - remote: {url}");
        return Utils.InvokeObject<IInclude_Remote>(_fullPath, _serviceLocator);
    }

    public IInclude_Template Template(string[] templates)
    {
        foreach(var template in templates)
        {
            Utils.WriteFile(_fullPath, $"  - template: {template}");
        }
        return Utils.InvokeObject<IInclude_Template>(_fullPath, _serviceLocator);
    }
}