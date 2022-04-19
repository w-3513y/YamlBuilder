using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Include;

namespace YamlBuilder.Builder.Include;

public class Local : Include, IInclude_Local
{
    public Local(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Project : Include, IInclude_Project
{
    public Project(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IInclude_File File(string[] files)
    {
        foreach(var file in files)
        {
            Utils.WriteFile(_fullPath, $"  file: {file}");
        }
        return Utils.InvokeObject<IInclude_File>(_fullPath, _serviceLocator);
    }

    public IInclude_Ref Ref(string branch)
    {
        Utils.WriteFile(_fullPath, $"  ref: {branch}");
        return Utils.InvokeObject<IInclude_Ref>(_fullPath, _serviceLocator);
    }
}

public class File : Include, IInclude_File
{
    public File(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class  Ref : Project, IInclude_Ref
{
    public Ref(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class  Remote : Include, IInclude_Remote
{
    public Remote(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Template : Include, IInclude_Template
{
    public Template(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}