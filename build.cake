#module nuget:?package=Cake.DotNetTool.Module&version=0.4.0
#tool dotnet:?package=GitVersion.Tool&version=5.3.7
#tool dotnet:?package=GitReleaseManager.Tool&version=0.11.0

var target = Argument("target", "Default");
GitVersion assertedVersions;
var token = "";

Task("GetCredentials")
    .Does(() =>
{
    token = EnvironmentVariable("GITHUB_TOKEN_DEMO");
});

Task("RunGitVersion")
    .IsDependentOn("GetCredentials")
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
    GitReleaseManagerCreate(token, "gep13-talks", "GitHubReleaseDemos", new GitReleaseManagerCreateSettings {
        Milestone         = assertedVersions.SemVer,
        Name              = assertedVersions.SemVer,
        Prerelease        = false,
        TargetCommitish   = "master"
    });
});

Task("AttachArtifact")
    .IsDependentOn("RunGitVersion")
    .Does(() =>
{
    GitReleaseManagerAddAssets(
        token,
        "gep13-talks",
        "GitHubReleaseDemos",
        assertedVersions.SemVer,
        MakeAbsolute(File("./LICENSE")).FullPath);
});

Task("CloseMilestone")
    .IsDependentOn("RunGitVersion")
    .Does(() =>
{
    GitReleaseManagerClose(
        token,
        "gep13-talks",
        "GitHubReleaseDemos",
        assertedVersions.SemVer);
});

Task("Default")
  .IsDependentOn("RunGitVersion");

RunTarget(target);