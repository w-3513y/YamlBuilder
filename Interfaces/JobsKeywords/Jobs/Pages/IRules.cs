using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IJobs_Pages_Rules:
    IJobs_Pages_Ifs_Navigation_lvl_3
{}

public interface IJobs_Pages_Rules_Navigation_lvl_2{
    public IJobs_Pages_Rules Rules();
}