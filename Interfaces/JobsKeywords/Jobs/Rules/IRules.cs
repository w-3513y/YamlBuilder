namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;


public interface IJobs_Rules:
    IJobs_Rules_Exists_Navigation_lvl_2,
    IJobs_Rules_Ifs_Navigation_lvl_2
 {
     public void Build(string condition);
 }

public interface IJobs_Rules_Navigation_lvl_1{
    public IJobs_Rules Rules(string condition);
}