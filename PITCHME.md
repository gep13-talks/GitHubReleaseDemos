@title[Control your GitHub releases with GitVersion and GitReleaseManager]

[drag=100 25, drop=center, set=h1-blue h3-blue]

## Control your GitHub releases

### with GitVersion and GitReleaseManager

---
@title[Slides and Code]

[drag=100 70]

## Slides

#### https://gep13.me/GitHubReleasesSlides

@fa[plus-square fa-2x fa-pad-icon text-gold]

## Code

#### https://gep13.me/GitHubReleasesCode

---
@title[Agenda]

## Agenda

---
@title[Agenda List]

@ul[drag=100, fit=1.5, list-spaced-sm-bullets]
- What is Semantic Versioning?
- What branching strategy should I use?
- What is GitVersion?
- Why do I need GitVersion?
- What is GitReleaseManager?
- Putting it all together...
@ul

Note:

- Fundamental principal - traceability
  - What version number does it have
  - What issues/pull requests are associated with it

---
@title[What is Semantic Versioning?]

[drag=30 100, drop=left, bg=black, set=h1-white]

# Q

[drag=70 25, drop=right, set=h2-gold]

#### What is

## Sematic Versioning @fa[question]

---
@title[Semantic Versioning Explained]

[drag=30 100, drop=left, bg=lightblue, set=h1-white]

# A

[drag=40 10, drop=60 0, set=text-gray]
Q. What is Semantic Versioning?

[drag=70 70, drop=right, pad=80px, fit=1.45]

@fa[quote-left] ...simple set of rules and requirements that dictate how version numbers are assigned and incremented. These rules are based on, but not necessarily limited to, pre-existing widespread common practices in use in both closed and open-source software.

Note:

- Loaded topic - large discussion
- Not going into the details

---
@title[The Rules]

[drag=100 15, drop=top]

### The rules

[drag=100 85, drop=0 15]

Given a version number MAJOR.MINOR.PATCH, increment the:

- MAJOR version when you make incompatible API changes
- MINOR version when you add functionality in a backwards-compatible manner
- PATCH version when you make backwards-compatible bug fixes

Additional labels for pre-release and build metadata are available<br> as extensions to the MAJOR.MINOR.PATCH format.

Note:

- A semantic version number expresses the intention of the release
- What has changed since the last version
- Not going to talk about how to know when to bump individual parts of the version number

---
@title[Semantic Versioning Examples]

[drag=100 15, drop=top]
### Examples

@ul[drag=100 85, drop=0 15]
- 0.1.0
- 0.3.13
- 1.0.0
- 0.2.0-unstable3
- @size[0.8em](0.2.0-unstable.3+Branch.develop.Sha.e6eb071cd30974b80d7e237b85e7729a1d791e1e)
@ul

---
@title[What branching strategy should I use?]

[drag=30 100, drop=left, bg=black, set=h1-white]

# Q

[drag=70 30, drop=right]

#### What
## @css[text-gold text-bold](branching strategy )
### should I use@fa[question]

Note:

- Again a loaded topic

---
@title[GitHub Flow]

## GitHub Flow

---
@title[GitHub Flow Explained]

@ul[drag=100 10, drop=top, sync=true, list-squash-bullets]
- #### Create a branch
- #### Add commits
- #### Open a Pull Request
- #### Discuss and review your code
- #### Deploy
- #### Merge
@ul

[drag=100 80, drop=0 10, stretch=true, flow=stack, sync=true]
![Create a branch](assets/images/githubflow.png)
![Add commits](assets/images/githubflow_2.png)
![Open a pull request](assets/images/githubflow_3.png)
![Discuss and review code](assets/images/githubflow_4.png)
![Deploy](assets/images/githubflow_5.png)
![Merge](assets/images/githubflow_6.png)

[drag=100 10, drop=bottom, set=text-gray, fit=0.5]

Images borrowed from the [GitHub Flow Tutorial](https://guides.github.com/introduction/flow/)

---
@title[GitFlow]

## GitFlow

---
@title[GitFlow Explained]

[drag=100 10, drop=top]

@ul[drag=100 10, drop=top, sync=true, list-squash-bullets]
- #### Two Main Branches
- #### Feature Branches
- #### Hotfix Branches
- #### Release Branches
- #### Overview
@ul

[drag=100 80, drop=0 10, flow=stack, sync=true]

![width=600px, alt=Two Main Branches](assets/images/gitflow_4.png)
![width=600px, alt=Feature Branches](assets/images/gitflow_2.png)
![width=600px, alt=Hotfix Branches](assets/images/gitflow_3.png)
![width=600px, alt=Release Branches](assets/images/gitflow_5.png)
![width=600px, alt=Overview](assets/images/gitflow.png)

[drag=100 10, drop=bottom, set=text-gray, fit=0.5]

Images borrowed from the [A successful git branching model](https://nvie.com/posts/a-successful-git-branching-model/)

---
@title[What is GitVersion]

[drag=30 100, drop=left, bg=black, set=h1-white]

# Q

[drag=70 20, drop=right]

#### What is

## @css[text-gold text-bold](GitVersion )@fa[question]

---
@title[GitVersion Explained]

[drag=30 100, drop=left, bg=lightblue, set=h1-white]

# A

[drag=40 10, drop=60 0, set=text-gray]
Q. What is GitVersion?

[drag=70 70, drop=right, pad=80px,  fit=1.4]

@fa[quote-left]...is a tool to help you achieve Semantic Versioning on your project.

Note:

- .Net Framework
- .Net Global Tool
- GitHub Action
- Doesn't help you decide when a version number need to change

---
@title[What is GitVersion really]

### Ok, but really, what is it?

---
@title[Why do I need GitVersion]

[drag=30 100, drop=left, bg=black, set=h1-white]

# Q

[drag=70 25, drop=right]

#### Why do I need

## @css[text-gold text-bold](GitVersion )@fa[question]

---
@title[GitVersion Reasons]

[drag=100, stretch=true, pad=100]

![Version Text File](assets/images/textfile.png)

---

[drag=100, stretch=true, pad=100]

![Assembly Info Files](assets/images/assemblyinfo.png)

---

[drag=100, stretch=true, pad=100]

![TeamCity Settings](assets/images/teamcitysetting.png)

Note:

- This couple you to a CI system

---

[drag=100, fit=7]
# ?

Note:

- No idea what the version number is

---
@title[What is GitReleaseManager]

[drag=30 100, drop=left, bg=black, set=h1-white]

# Q

[drag=70 25, drop=right]

#### What is

## @css[text-gold text-bold](GitReleaseManager )@fa[question]

---
@title[GitReleaseManager Explained]

[drag=30 100, drop=left, bg=lightblue, set=h1-white]

# A

[drag=40 10, drop=60 0, set=text-gray]
Q. What is GitReleaseManager?

[drag=70 70, drop=right, pad=80px, fit=1.4]

@fa[quote-left]...is a tool that will help create a set of release notes for your application/product. It does this using the collection of issues which are stored on the GitHub Issue Tracker for your application/product.

Note:

- Started out as a tool from Particular

---
@title[What is GitReleaseManager really]

## Ok, but really, what is it?

Note:

- .Net Framework
- .Net Global Tool
- GitHub Action

---

@title[Putting it all together]

## Putting it all together...

---?color=beige
@title[Demo]

[drag=100, fit=3.3]
# DEMO

---
@title[Questions]

[drag=100 50]

## Questions

Feel free to get in touch

Email: gep13@gep13.co.uk

Twitter: @gep13

Web: https://www.gep13.co.uk

---?color=#7FDBFF
@title[Who Am I? - Gary Ewan Park]

[drag=50 10, drop=topleft]
#### Who am I?

[drag=50 30, drop=0 10, flow=row]

Senior Software Engineer @<br> Chocolatey Software

[drag=50 50, drop=0 30, flow=row]

![Chocolatey](assets/images/chocolatey.png)
![MVP Logo](assets/images/mvp.jpg)
![Cake Build](assets/images/cake.png)

[drag=50 10, drop=bottomleft, flow=row, fit=0.5]

@fa[twitter twitter-blue] gep13
@fa[github text-black] github.com/gep13
@fa[home text-blue] gep13.co.uk
@fa[envelope choco-blue] gary@chocolatey.io

[drop=right]

![Gary Ewan Park](assets/images/gary-avatar.jpeg)

Gary Ewan Park

---
@title[Learn More]

[drag=100 30, drop=top]

## Learn More

[drag=100 70, drop=0 30]
@ul[list-spaced-sm-bullets, fit=0.9](false)
- GitVersion Documentation
  - https://gitversion.net/docs/
- .Net Rocks Episode with Jake Ginnivan
  - https://www.dotnetrocks.com/default.aspx?showNum=1178
- Git Branching Strategies
  - https://www.atlassian.com/git/tutorials/comparing-workflows
- GitFlow
  - https://nvie.com/posts/a-successful-git-branching-model/
@ul
