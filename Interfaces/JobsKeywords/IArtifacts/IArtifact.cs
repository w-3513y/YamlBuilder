using YamlBuilder.Enums;
using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts;

public interface IArtifact: IDefault{
  public IName Name(string name);
  public IPaths Paths(string[] paths);
  public IExpireIn Expire_in(string time);
  public IExclude Exclude(string files);
  public IExposeAs Expose_as(string name);
  public IPublic Public(bool publ);
  public IReport Report();
  public IUntracked Untracked(bool untracked);
  public IWhen When(JobEnum onlyWhen);
}


/*  
    Job artifacts are a list of files and directories that are attached to the job when it succeeds, fails, or always.
      The artifacts are sent to GitLab after the job finishes. They are available for download in the GitLab UI if the 
      size is smaller than the the maximum artifact size.
      By default, jobs in later stages automatically download all the artifacts created by jobs in earlier stages. 
      You can control artifact download behavior in jobs with dependencies.
      When using the needs keyword, jobs can only download artifacts from the jobs defined in the needs configuration.
      Job artifacts are only collected for successful jobs by default, and artifacts are restored after caches.

Example: 

If you use Windows Batch to run your shell scripts you must replace $ with %:

  artifacts:
    name: "%CI_JOB_STAGE%-%CI_COMMIT_REF_NAME%"
    paths:
      - binaries/
    expire_in: 1 week
*/
