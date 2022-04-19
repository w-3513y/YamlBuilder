using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IWorkFlow_When:
    IJobs_Navigation_lvl_0,
    IWorkFlow_Ifs_Navigation_lvl_2,
    IWorkFlow_AllowFailure_Navigation_lvl_3
{}

public interface IWorkFlow_When_Navigation_lvl_3{
    public IWorkFlow_When When(Enums.When when);
}