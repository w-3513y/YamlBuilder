using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface IJobs_Release:
    IJobs_Release_TagName_Navigation_lvl_2,
    IJobs_Release_NameNavigation_lvl_2,
    IJobs_Release_Ref_Navigation_lvl_2,
    IJobs_Release_Milestones_Navigation_lvl_2,
    IJobs_Release_ReleasedAt_lvl_2
{
    public void Build();
}

public interface IJobs_Release_Navigation_lvl_1{
    public IJobs_Release Release();
}