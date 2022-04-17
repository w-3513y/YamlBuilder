using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;

public interface IKubernetes:
    //going up 3 level(s) abouve
    //going up 1 level(s)
    //going down 1 level(s)
    INameSpaceNavigation
{}

public interface IKubernetesNavigation{
    public IKubernetes Kubernetes();   
}
