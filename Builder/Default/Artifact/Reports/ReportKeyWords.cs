using YamlBuilder.Builder.Default.Artifact.Reports;
using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Builder.Default.Artifact.Reports;

public class Acessibility : Report, IDefault_Artifacts_Report_Acessibility
{
    public Acessibility(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string report)
        => Utils.WriteFile(_fullPath, $"      acessibility: {report}");
}

public class CodeQuality : Report, IDefault_Artifacts_Report_CodeQuality
{
    public CodeQuality(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string report) 
        => Utils.WriteFile(_fullPath, $"      codequality: {report}");
}

public class CoverageReport : Report, IDefault_Artifacts_Report_CoverageReport
{
    public CoverageReport(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public new void Build()
        => Utils.WriteFile(_fullPath, $"      coverage_report:");

    public IDefault_Artifacts_Report_CoverageFormat CoverageFormat(string format)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report_CoverageFormat>().Build(format);
        return _serviceLocator.GetService<IDefault_Artifacts_Report_CoverageFormat>();
    }
}

public class CoverageFormat: CoverageReport, IDefault_Artifacts_Report_CoverageFormat
{
    public CoverageFormat(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string format)
        => Utils.WriteFile(_fullPath, $"        coverage_format: {format}");

    public IDefault_Artifacts_Report_Path Path(string path)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report_Path>().Build(path);
        return _serviceLocator.GetService<IDefault_Artifacts_Report_Path>();
    }
}

public class Path: CoverageFormat, IDefault_Artifacts_Report_Path
{
    public new void Build(string path)
        => Utils.WriteFile(_fullPath, $"        path: {path}");
    
    public Path(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class DotEnv : Report, IDefault_Artifacts_Report_DotEnv
{
    public DotEnv(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string report)
        => Utils.WriteFile(_fullPath, $"      dotenv: {report}");
}

public class JUnit : Report, IDefault_Artifacts_Report_JUnit
{
    public JUnit(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string report)
        => Utils.WriteFile(_fullPath, $"      junit: {report}");
}

public class Sast : Report, IDefault_Artifacts_Report_Sast
{
    public Sast(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string report)
        => Utils.WriteFile(_fullPath, $"      sast: {report}");
}

public class SecretDetection : Report, IDefault_Artifacts_Report_SecretDetection
{
    public SecretDetection(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string report)
        => Utils.WriteFile(_fullPath, $"      secret_detection: {report}");
}

public class Terraform : Report, IDefault_Artifacts_Report_Terraform
{
    public Terraform(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string report)
        => Utils.WriteFile(_fullPath, $"      terraform: {report}");
}