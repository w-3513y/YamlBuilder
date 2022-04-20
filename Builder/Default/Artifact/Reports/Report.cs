using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Builder.Default.Artifact.Reports;

public class Report : Artifacts, IDefault_Artifacts_Report
{
    public Report(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IDefault_Artifacts_Report_Acessibility Acessibility(string report)
    {
        Utils.WriteFile(_fullPath, $"      acessibility: {report}");
        return _serviceLocator.GetService<IDefault_Artifacts_Report_Acessibility>();
    }

    public IDefault_Artifacts_Report_CodeQuality CodeQuality(string report)
    {
        Utils.WriteFile(_fullPath, $"      codequality: {report}");
        return _serviceLocator.GetService<IDefault_Artifacts_Report_CodeQuality>();
    }

    public IDefault_Artifacts_Report_CoverageReport CoverageReport()
    {
        Utils.WriteFile(_fullPath, $"      coverage_report:");
        return _serviceLocator.GetService<IDefault_Artifacts_Report_CoverageReport>();
    }

    public IDefault_Artifacts_Report_DotEnv DotEnv(string report)
    {
        Utils.WriteFile(_fullPath, $"      dotenv: {report}");
        return _serviceLocator.GetService<IDefault_Artifacts_Report_DotEnv>();
    }

    public IDefault_Artifacts_Report_JUnit JUnit(string report)
    {
        Utils.WriteFile(_fullPath, $"      junit: {report}");
        return _serviceLocator.GetService<IDefault_Artifacts_Report_JUnit>();
    }

    public IDefault_Artifacts_Report_Sast Sast(string report)
    {
        Utils.WriteFile(_fullPath, $"      sast: {report}");
        return _serviceLocator.GetService<IDefault_Artifacts_Report_Sast>();
    }

    public IDefault_Artifacts_Report_SecretDetection SecretDetection(string report)
    {
        Utils.WriteFile(_fullPath, $"      secret_detection: {report}");
        return _serviceLocator.GetService<IDefault_Artifacts_Report_SecretDetection>();
    }

    public IDefault_Artifacts_Report_Terraform Terraform(string report)
    {
        Utils.WriteFile(_fullPath, $"      terraform: {report}");
        return _serviceLocator.GetService<IDefault_Artifacts_Report_Terraform>();
    }
}