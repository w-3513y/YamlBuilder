using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IWorkFlow_AllowFailure:
    IJobs_Navigation_lvl_0,
    IWorkFlow_Ifs_Navigation_lvl_2
{
    public void Build(bool allowFailure);
}

public interface IWorkFlow_AllowFailure_Navigation_lvl_3{
    public IWorkFlow_AllowFailure AllowFailure(bool allowFailure);
}