using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Include;

namespace YamlBuilder.Builder.Include;

public class Local : Include, IInclude_Local
{
    public Local(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string file)
        => Utils.WriteFile(_fullPath, $"  - local: {file}");
}

public class Project : Include, IInclude_Project
{
    public Project(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string project) => Utils.WriteFile(_fullPath, $"  - project: {project}");

    public IInclude_File File(string[] files)
    {
        _serviceLocator.GetService<IInclude_File>().Build(files);
        return _serviceLocator.GetService<IInclude_File>();
    }

    public IInclude_Ref Ref(string branch)
    {
        _serviceLocator.GetService<IInclude_Ref>().Build(branch);
        return _serviceLocator.GetService<IInclude_Ref>();
    }
}

public class File : Include, IInclude_File
{
    public File(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string[] files)
    {
        foreach (var file in files)
        {
            Utils.WriteFile(_fullPath, $"  file: {file}");
        }
    }
}

public class  Ref : Project, IInclude_Ref
{
    public Ref(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public new void Build(string branch) => Utils.WriteFile(_fullPath, $"  ref: {branch}");
}

public class  Remote : Include, IInclude_Remote
{
    public Remote(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string url) => Utils.WriteFile(_fullPath, $"  - remote: {url}");
}

public class Template : Include, IInclude_Template
{
    public Template(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string[] templates)
    {
        foreach (var template in templates)
        {
            Utils.WriteFile(_fullPath, $"  - template: {template}");
        }

    }
}