namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;

public interface IJobs_Rules_Ifs:
    IJobs_Rules_Changes_Navigation_lvl_3,
    IJobs_Rules_Variables_Navigation_lvl_3,
    IJobs_Rules_When_Navigation_lvl_3,
    IJobs_Rules_AllowFailure_Navigation_lvl_3
 {}

public interface IJobs_Rules_Ifs_Navigation_lvl_2{
    public IJobs_Rules_Ifs Ifs(string condition);
}