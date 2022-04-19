using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Include;

namespace YamlBuilder.Builder.Include;

public class IncludeShortSyntax : GitLabYaml, IIncludeShortSyntax
{
     public IncludeShortSyntax(string path) : base(path) {}
}

public class Include : GitLabYaml, IInclude
{

    public Include(string path) : base(path) {}

    public IIInclude_Local Local(string file)
    {
        throw new NotImplementedException();
    }

    public IInclude_Project Project(string project)
    {
        throw new NotImplementedException();
    }

    public IInclude_Remote Remote(string url)
    {
        throw new NotImplementedException();
    }

    public IInclude_Template Template(string[] templates)
    {
        throw new NotImplementedException();
    }
}