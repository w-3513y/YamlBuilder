using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Builder.Default.Artifact.Reports;

public class Report : Artifacts, IDefault_Artifacts_Report
{
    public Report(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public new void Build()
        => Utils.WriteFile(_fullPath, $"    reports:");

    public IDefault_Artifacts_Report_Acessibility Acessibility(string report)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report_Acessibility>().Build(report);
        return _serviceLocator.GetService<IDefault_Artifacts_Report_Acessibility>();
    }

    public IDefault_Artifacts_Report_CodeQuality CodeQuality(string report)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report_CodeQuality>().Build(report);
        return _serviceLocator.GetService<IDefault_Artifacts_Report_CodeQuality>();
    }

    public IDefault_Artifacts_Report_CoverageReport CoverageReport()
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report_CoverageReport>().Build();
        return _serviceLocator.GetService<IDefault_Artifacts_Report_CoverageReport>();
    }

    public IDefault_Artifacts_Report_DotEnv DotEnv(string report)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report_DotEnv>().Build(report);
        return _serviceLocator.GetService<IDefault_Artifacts_Report_DotEnv>();
    }

    public IDefault_Artifacts_Report_JUnit JUnit(string report)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report_JUnit>().Build(report);
        return _serviceLocator.GetService<IDefault_Artifacts_Report_JUnit>();
    }

    public IDefault_Artifacts_Report_Sast Sast(string report)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report_Sast>().Build(report);
        return _serviceLocator.GetService<IDefault_Artifacts_Report_Sast>();
    }

    public IDefault_Artifacts_Report_SecretDetection SecretDetection(string report)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report_SecretDetection>().Build(report);
        return _serviceLocator.GetService<IDefault_Artifacts_Report_SecretDetection>();
    }

    public IDefault_Artifacts_Report_Terraform Terraform(string report)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report_Terraform>().Build(report);
        return _serviceLocator.GetService<IDefault_Artifacts_Report_Terraform>();
    }
}