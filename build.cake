#tool nuget:?package=gitreleasemanager&version=0.5.0
#tool nuget:?package=GitVersion.CommandLine&version=3.6.2

var target = Argument("target", "Default");
GitVersion assertedVersions;

Task("RunGitVersion")
    .Does(() =>
{
    assertedVersions = GitVersion(new GitVersionSettings
    {
        OutputType = GitVersionOutput.Json,
    });

    Information("Informational Version: {0}", assertedVersions.InformationalVersion);
    Information("SemVer Version: {0}", assertedVersions.SemVer);
});

Task("CreateReleaseNotes")
    .IsDependentOn("RunGitVersion")
    .Does(() =>
{
    var username = EnvironmentVariable("GITHUB_USERNAME_DEMO");
    var password = EnvironmentVariable("GITHUB_PASSWORD_DEMO");

    GitReleaseManagerCreate(username, password, "gep13", "GitHubReleaseDemos", new GitReleaseManagerCreateSettings {
        Milestone         = assertedVersions.SemVer,
        Name              = assertedVersions.SemVer,
        Prerelease        = false,
        TargetCommitish   = "master"
    });
});

Task("Default")
  .IsDependentOn("RunGitVersion");

RunTarget(target);