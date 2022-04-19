using YamlBuilder.Interfaces.JobsKeywords.Include;

namespace YamlBuilder.Builder.Include;

public class Local : Include, IInclude_Local
{
    public Local(string filePath) : base(filePath) {}
}

public class Project : Include, IInclude_Project
{
    public Project(string filePath) : base(filePath) {}

    public IInclude_File File(string[] files)
    {
        foreach(var file in files)
        {
            Utils.WriteFile(_fullPath, $"  file: {file}");
        }
        return Utils.InvokeObject<IInclude_File>(_fullPath);
    }

    public IInclude_Ref Ref(string branch)
    {
        Utils.WriteFile(_fullPath, $"  ref: {branch}");
        return Utils.InvokeObject<IInclude_Ref>(_fullPath);
    }
}

public class File : Include, IInclude_File
{
    public File(string filePath) : base(filePath) {}
}

public class  Ref : Project, IInclude_Ref
{
    public Ref(string filePath) : base(filePath) {}
}

public class  Remote : Include, IInclude_Remote
{
    public Remote(string filePath) : base(filePath) {}
}

public class Template : Include, IInclude_Template
{
    public Template(string filePath) : base(filePath) {}
}