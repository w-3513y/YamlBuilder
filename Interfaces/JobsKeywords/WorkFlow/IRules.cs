namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IWorkFlow_Rules:
    IWorkFlow_Exists_Navigation_lvl_2,
    IWorkFlow_Ifs_Navigation_lvl_2
 {
     public void Build(string condition);
 }

public interface IWorkFlow_Rules_Navigation_lvl_1{
    public IWorkFlow_Rules Rules(string condition);
}