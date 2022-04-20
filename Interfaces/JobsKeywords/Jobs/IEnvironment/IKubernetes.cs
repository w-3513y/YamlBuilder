namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;

public interface IJobs_Environment_Kubernetes:
    IJobs_Environment_NameSpace_Navigation_lvl_4
{
    public void Build();
}

public interface IJobs_Environment_Kubernetes_Navigation_lvl_3{
    public IJobs_Environment_Kubernetes Kubernetes();   
}
