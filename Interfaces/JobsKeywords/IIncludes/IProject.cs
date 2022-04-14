namespace YamlBuilder.Interfaces.JobsKeywords.IIncludes;

public interface IProject{
    public IFile File(string[] files);
    public IRef Ref(string branch);
}