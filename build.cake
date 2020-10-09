#module nuget:?package=Cake.DotNetTool.Module&version=0.4.0
#tool dotnet:?package=GitVersion.Tool&version=5.3.7
#tool dotnet:?package=GitReleaseManager.Tool&version=0.11.0

var target = Argument("target", "Default");
GitVersion assertedVersions;
var username = "";
var password = "";

Task("GetCredentials")
    .Does(() =>
{
    username = EnvironmentVariable("GITHUB_USERNAME_DEMO");
    password = EnvironmentVariable("GITHUB_PASSWORD_DEMO");
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
    GitReleaseManagerCreate(username, password, "gep13", "GitHubReleaseDemos", new GitReleaseManagerCreateSettings {
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
        username,
        password,
        "gep13",
        "GitHubReleaseDemos",
        assertedVersions.SemVer,
        MakeAbsolute(File("./LICENSE")).FullPath);
});

Task("CloseMilestone")
    .IsDependentOn("RunGitVersion")
    .Does(() =>
{
    GitReleaseManagerClose(
        username,
        password,
        "gep13",
        "GitHubReleaseDemos",
        assertedVersions.SemVer);
});

Task("Default")
  .IsDependentOn("RunGitVersion");

RunTarget(target);