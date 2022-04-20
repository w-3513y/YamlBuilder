using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IDefault_Services:
    IDefault_Services_Name_Navigation_lvl_2
{
    public void Build();
}

public interface IDefault_ServicesShortSyntax:
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1
{
    public void Build(string[] commands);
}


public interface IDefault_Services_Navigation_lvl_1{
    public IDefault_Services Services();   
    public IDefault_ServicesShortSyntax Services(string[] commands);
}