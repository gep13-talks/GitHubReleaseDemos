## GitVersion Demos

### Demo 1 - basic usage

* Open PowerShell
* Navigate to repository folder
* Switch to develop branch `git checkout develop`
* Run gitversion `.\tools\GitVersion.CommandLine\tools\GitVersion.exe`
* Zoom in to show output
* Make an empty commit `git commit -m "test" --allow-empty`
* Run GitVersion again, show how it is updating and tracking the number

### Demo 2 - Feature Branch

* Create a feature branch `git checkout -b feature/ddd12 develop`
* Run GitVersion, note how it now knows we are on a feature branch
* Make a commit
* Run GitVersion again, show again how it is tracking the version number

### Demo 3 - Release Branch

* Create a release branch `git checkout -b release/0.1.0 develop`
* Run GitVersion, not how it now knows we are on a release branch
* Make a commit
* Run GitVersion again, show again how it is tracking the version number

### Demo 4 - Merge into master

* Check out master branch
* Merge develop branch into master `git merge --no-ff release/0.1.0`
* Run GitVersion, note how it now knows we are on master branch
* Done