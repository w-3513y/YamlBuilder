using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Builder.Default.Artifact.Reports;

public class Report : Artifacts, IDefault_Artifacts_Report
{
    public Report(string path) : base(path){}

    public IDefault_Artifacts_Report_Acessibility Acessibility(string report)
    {
        Utils.WriteFile(_fullPath, $"      acessibility: {report}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_Acessibility>(_fullPath);
    }

    public IDefault_Artifacts_Report_CodeQuality CodeQuality(string report)
    {
        Utils.WriteFile(_fullPath, $"      codequality: {report}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_CodeQuality>(_fullPath);
    }

    public IDefault_Artifacts_Report_CoverageReport CoverageReport()
    {
        Utils.WriteFile(_fullPath, $"      coverage_report:");
        return Utils.InvokeObject<IDefault_Artifacts_Report_CoverageReport>(_fullPath);
    }

    public IDefault_Artifacts_Report_DotEnv DotEnv(string report)
    {
        Utils.WriteFile(_fullPath, $"      dotenv: {report}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_DotEnv>(_fullPath);
    }

    public IDefault_Artifacts_Report_JUnit JUnit(string report)
    {
        Utils.WriteFile(_fullPath, $"      junit: {report}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_JUnit>(_fullPath);
    }

    public IDefault_Artifacts_Report_Sast Sast(string report)
    {
        Utils.WriteFile(_fullPath, $"      sast: {report}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_Sast>(_fullPath);
    }

    public IDefault_Artifacts_Report_SecretDetection SecretDetection(string report)
    {
        Utils.WriteFile(_fullPath, $"      secret_detection: {report}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_SecretDetection>(_fullPath);
    }

    public IDefault_Artifacts_Report_Terraform Terraform(string report)
    {
        Utils.WriteFile(_fullPath, $"      terraform: {report}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_Terraform>(_fullPath);
    }
}