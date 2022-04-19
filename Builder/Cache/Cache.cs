using YamlBuilder.Enums;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;

namespace YamlBuilder.Builder.Default.Cache;

public class Cache : Default, IDefault_Cache
{
    public Cache(string path) : base(path){}

    public IDefault_Cache_Key Key(string name)
    {
        throw new NotImplementedException();
    }

    public IDefault_Cache_Paths Paths(string[] directories)
    {
        throw new NotImplementedException();
    }

    public IDefault_Cache_Policy Policy(GitCommand command)
    {
        throw new NotImplementedException();
    }

    public IDefault_Cache_Untracked Untracked(bool publc)
    {
        throw new NotImplementedException();
    }

    public IDefault_Cache_When When(JobGlobal when)
    {
        throw new NotImplementedException();
    }
}