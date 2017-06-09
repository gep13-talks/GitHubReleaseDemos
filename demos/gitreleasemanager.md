## GitReleaseManager Demos

### Demo 1 - Creating Release Notes

* Open PowerShell
* Navigate to repository folder
* Open Browser to GitHub Repository and show open issues
* Close all the issues
* Switch to releases section and show that there are no releases
* Switch to master branch `git checkout master`
* Run the Cake build script `./build.ps1`
* Show that GitVersion is being run to assert the version number
* Run `./build.ps1 -target CreateReleaseNotes`
* Switch back to browser, and refresh releases section
* Show draft release

### Demo 2 - Attaching artifact

* Switch back to browser and show there are no release artifacts
* Run `./build.ps1 -target AttachArtifact`
* Switch back to browser and show attachment


### Demo 3 - Close milestone

* In the browser, switch to milestone view, and show that it is still open
* Run `./build.ps1 -target CloseMilestone`
* Switch back to browser and show that milestone is now closed