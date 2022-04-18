namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;

public interface IKubernetes:
    //going down 1 level(s)
    INameSpaceNavigation
{}

public interface IKubernetesNavigation{
    public IKubernetes Kubernetes();   
}
