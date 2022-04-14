using YamlBuilder.Interfaces.JobsKeywords.IIncludes;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IInclude{
    public ILocal Local(string file);
    public IProject Project(string file); 
    public IRemote Remote(string url);
    public ITemplate Template(string[] templates);
}
