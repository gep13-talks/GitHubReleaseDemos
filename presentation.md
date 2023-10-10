---
marp: true
theme: gaia
_class: lead
backgroundColor: #fff
backgroundImage: url('https://marp.app/assets/hero-background.svg')
footer: @gep13
style: |
    @import 'https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/css/all.min.css'
---

# **Let's Ship This Thing! :rocket:**
<span style="color:gray">By:</span> Gary Ewan Park


---
<!-- paginate: true -->
<!-- class: lead -->
# Slides

https://gep13.me/ShipItSlides

<i class="fa fa-plus-square fa-2x" aria-hidden="true"></i>

# Code

https://gep13.me/ShipItCode

---
# Agenda
---
* What is Semantic Versioning?
* What branching strategy should I use?
* What is GitVersion?
* Why do I need GitVersion?
* What is GitReleaseManager?
* Putting it all together...

---
![bg left:33%](https://fakeimg.pl/800x600/000/fff/?text=Q)

#### What is
## Semantic Versioning<i class="fa fa-question" aria-hidden="true"></i>

---
<!--
header: Q. What is Semantic Versioning?
-->

![bg left:33%](https://fakeimg.pl/800x600/add8e6/fff/?text=A)

#### <i class="fa fa-quote-left" aria-hidden="true"></i> ...a simple set of rules and requirements that dictate how version numbers are assigned and incremented. These rules are based on, but not necessarily limited to, pre-existing widespread common practices in use in both closed and open-source software.

---

<!--
header: ""
-->
## The Rules

Given a version number MAJOR.MINOR.PATCH, increment the:

- MAJOR version when you make incompatible API changes
- MINOR version when you add functionality in a backwards-compatible manner
- PATCH version when you make backwards-compatible bug fixes

Additional labels for pre-release and build metadata are available as extensions to the MAJOR.MINOR.PATCH format.

---

## Examples

- 0.1.0
- 0.3.13
- 1.0.0
- 0.2.0-unstable3
- 0.2.0-unstable.3+Branch.develop.Sha.e6eb071cd30974b80d7e237b85e7729a1d791e1e

---
![bg left:33%](https://fakeimg.pl/800x600/000/fff/?text=Q)

#### What
## branching strategy
### should I use<i class="fa fa-question" aria-hidden="true"></i>

---
<!--
header: Q. What branching strategy should I use?
-->

![bg left:33%](https://fakeimg.pl/800x600/add8e6/fff/?text=A)

#### It depends!

---
<!--
header: ""
-->

![bg left:33%](https://fakeimg.pl/800x600/000/fff/?text=Q)

#### What is
## GitVersion<i class="fa fa-question" aria-hidden="true"></i>

---

<!--
header: Q. What is GitVersion?
-->

![bg left:33%](https://fakeimg.pl/800x600/add8e6/fff/?text=A)

#### <i class="fa fa-quote-left" aria-hidden="true"></i>...a tool to help you achieve Semantic Versioning on your project.

---

<!--
header: ""
-->

## Ok, but really what is it?

---
<!--
header: ""
-->

![bg left:33%](https://fakeimg.pl/800x600/000/fff/?text=Q)

#### Why do I need
## GitVersion<i class="fa fa-question" aria-hidden="true"></i>

---

<!--
header: Q. Why do I need GitVersion?
-->

![bg left:33%](https://fakeimg.pl/800x600/add8e6/fff/?text=A)

### To make version assertion reliable and consistent

---

<!--
header: ""
-->

![bg left:33%](https://fakeimg.pl/800x600/000/fff/?text=Q)

#### What is
## GitReleaseManager<i class="fa fa-question" aria-hidden="true"></i>

---

<!--
header: Q. What is GitReleaseManager?
-->

![bg left:33%](https://fakeimg.pl/800x600/add8e6/fff/?text=A)

#### <i class="fa fa-quote-left" aria-hidden="true"></i> a tool that will help create a set of release notes for your application/product. It does this using the collection of issues which are stored on the GitHub Issue Tracker for your application/product.

---

<!--
header: ""
-->

## Ok, but really what is it?

---

## Putting is all together...

---
<!--
_backgroundColor: 
-->
## <!--fit -->Demo

---

## Questions
### Feel free to get in touch
### Email: gep13@gep13.co.uk
### Twitter: @gep13
### Web: https://gep13.co.uk

---
![bg left:40%](./assets/images/gary-avatar.png)

## Gary Ewan Park
### Principal Software Engineer<br/>Chocolatey Software, Inc

<i class="fa-brands fa-twitter"></i> Twitter: @gep13
<i class="fa-brands fa-mastodon"></i> Mastodon: 
<i class="fa-brands fa-linkedin"></i> LinkedIn: 
<i class="fa fa-window-maximize"></i> Blog: https://gep13.co.uk
<i class="fa-brands fa-github"></i> GitHub: [gep13](https://github.com/gep13)

---
## Learn More

- GitVersion Documentation
  - https://gitversion.net/docs/
- GitReleaseManager Documentation
  - https://gittools.github.io/GitReleaseManager/docs/
- .Net Rocks Episode with Jake Ginnivan
  - https://www.dotnetrocks.com/default.aspx?showNum=1178
- Git Branching Strategies
  - https://www.atlassian.com/git/tutorials/comparing-workflows
- GitFlow
  - https://nvie.com/posts/a-successful-git-branching-model/