using YamlBuilder.Interfaces.JobsKeywords.Include;

namespace YamlBuilder.Builder.Include;

public class Local : Include, IIInclude_Local
{
    public Local(string filePath) : base(filePath) {}
}

public class Project : Include, IInclude_Project
{
    public Project(string filePath) : base(filePath) {}

    public IInclude_File File(string[] files)
    {
        throw new NotImplementedException();
    }

    public IInclude_Ref Ref(string branch)
    {
        throw new NotImplementedException();
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