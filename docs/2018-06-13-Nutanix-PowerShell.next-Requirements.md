---
title: Nutanix PowerShell.next Requirements
layout: post
author: jonatha.kohler
permalink: /nutanix-powershell.next-requirements/
source-id: 1Sk9ypyB3Z1jq665nUEj0bXwgkPeNyObRW5fuUHrEj8o
published: true
---
**_PowerShell.Next (PoSh 2.0) Project_**

**Owner:** Jon Kohler (jon@nutanix.com) 

**Dev Lead: **Alex Guo

**PM: **Tarak Parekh

**GitHub**:[ https://github.com/nutanix/PowerShell](https://github.com/nutanix/PowerShell)

**JIRA**: [https://jira.nutanix.com/browse/FEAT-6441](https://jira.nutanix.com/browse/FEAT-6441) 

**DL**: [PowerShell@nutanix.com](mailto:PowerShell@nutanix.com)

**Slack**: #_powershell_ext @ nutanix.slack.com

[[TOC]]

### Why & Goals* * *


Nutanix is committed to making PowerShell a first-class feature. In service of that goal, Nutanix is deprecating the existing PowerShell cmdlets included with AOS as of (tentative 5.5.1, 5.1.5). 

Nutanix cmdlets are being replaced with a "from the ground up" rewrite, leveraging our latest API's and Microsoft's PowerShell 6.x code train. 

This new release will fundamentally enhance our functionality, including:

* PowerShell 6.0 Support for Windows, Linux, and OSX

* Module support, for easy integration with editors like Visual Studio Code

* PowerShell Gallery support, for ease of deployment

* Simplified, easy to use Cmdlets with traditional virtualization sysadmin semantics 

* Verbose Get-Help with detailed examples on each cmdlet

* Production supported, with additional Open Source community collaboration on GitHub and Slack

* Nutanix v3 API support - This means Calm, Micro Seg, and all of the other goodies. 

    * Note: legacy API's will only be leveraged for methods not yet available in v3 API 

Nutanix is taking an inclusive approach to developing this new feature and welcomes customer feedback. Please see our development project on GitHub, comment on requirements and/or design, and feel free to join us on Slack. Instructions on commenting, contributing, and joining our community Slack channel are all located within our GitHub Readme.

### Prerequisites

* * *


1. Deprecate existing cmdlets

### Target User Scenarios

* * *


1. User using PowerShell against Prism Central *OR* Prism Element

    1. Prism Element will naturally have less functionality over time, as advanced features move into Prism Central

    2. Maintaining PE compatibility will help with smaller environments, such as single cluster deployments

### What we are NOT targeting

* * *


* **Enhancements to existing cmdlets**

### Requirements and Comments 

* * *


**_PowerShell.Next @ Nutanix_**: [https://jira.nutanix.com/browse/FEAT-6441](https://jira.nutanix.com/browse/FEAT-6441) 

Requirements here also include the 'intent' of the requirement from a user’s perspective in *italics*. 

 

1. Open source day 1 

    1. GitHub (private for now):[ https://github.com/nutanix/PowerShell](https://github.com/nutanix/PowerShell)

    2. Rubrik and VMware have both open sourced / hosted their PowerShell cmdlet code on GitHub.

        1. [https://github.com/rubrikinc/PowerShell-Module](https://github.com/rubrikinc/PowerShell-Module)

        2. [https://github.com/vmware/powernsx](https://github.com/vmware/powernsx)

    3. This does a lot of good things, including giving people access to submit engineering issues against this code right in GitHub, as well as contribute to the base via pull requests.

    4. We should follow suit. Leveraging the power of the community could be huge here, and really help us step up our game against the competition.

2. We need to do this in PowerShell 6.0, which is written in .net core. 

    5. This will get us cross platform from day 1 

    6. GitHub Site is here - [https://github.com/PowerShell/PowerShell](https://github.com/PowerShell/PowerShell)

    7. Covers: PM-1008 Make PowerShell cmdlets work on OSX / Linux

3. Need to be easy to develop against, i.e work within editors like Visual Studio code

    8. From Darren Woolard about existing cmdlets: I've installed the Nutanix cmdlets into my Win7 VM. All work and I can run commands. If I try an use an editor (to assist with debug, syntax highlighting, etc…) the cmdlets don’t appear to be registered. I’ve tried Powershell ISE (native) and a 3rd party tool called Powershell Plus (by Idera). I can see other 3rd party cmdlets shown in the editors but not ours.

4. PowerShell gallery installable 

    9. This would be similar to how others (like VMW) have done things, so that someone could do Install-Module -Name Nutanix.CLI

    10. During development, we'll likely have to have an installable before we publish to the PowerShell gallery

    11. Need to update Prism Element and Prism Central to point at gallery OR package a "mainline/stable" distro with the cluster for dark sites

    12. Should be installable with "PowerShellGet"

5. Everything is a powershell module

    13. Meaning, no snapins, no DLLs, no objects that need to be side loaded with a batch file.

    14. We may be factoring different code trains into different modules where it makes sense, like Nutanix.CLI.Core, Nutanix.CLI.AFS, Nutanix.CLI.Calm, etc

6. Workflow support, such that cmdlets can be executed in parallel

7. PsCredential support, such that

    15. A service account running a script could authenticate without storing password in script

8. Publishing should be done under corporate gallery account

9. Figure out documentation push to portal

    16. Documentation should be living within source code, and then should be scraped over to Portal, such that it appears as a traditional product doc

    17. Think about "get-help for updates" - this in 2016? Would this get overridden by gallery updates? Or how would that interop

10. Template output support

    18. set-NTNXVMDisk -template | format-custom

11. Unit testing

    19. Need PESTER support

    20. Think about testing against virtual clusters

12. PowerShell winSSH support

    21. Wouldn't it be nice to wrapper NCLI/ACLI, such that you can just plumb stuff in that doesn’t have an API set yet

13. Comply with powershell publishing best practices

    22. Use PSScriptAnalyzer

    23. Include documentation and examples

    24. Be responsive to feedback

    25. Provide modules rather than scripts

    26. Provide links to a project site

    27. Include tests with your modules

    28. Include and/or link to license terms

    29. Sign your code

    30. Follow SemVer guidelines for versioning

    31. Use common tags, as documented in Common PowerShell Gallery tags

    32. Test publishing using a local repository

14. Every cmdlet has a full get-help for all variables, flags, and commands

    33. This needs to include one or more examples for every single cmdlet

    34. Just a few points on functions vs cmdlets if you haven't seen it already: [http://www.leeholmes.com/blog/2007/07/24/cmdlets-vs-functions/](http://www.leeholmes.com/blog/2007/07/24/cmdlets-vs-functions/)

15. Cmdlets are ***extremely* **easy to use. 

    35. For example, I should be able to make a VM with two cmdlets, with a "connect" statement, then a “new-vm” statement, that's it.

    36. There may be other supporting things I need to do here, in general, like "get" network to plumb into net-vm.

    37. All Powershell modules should report user friendly and actionable error messages (and not just "error occurred"). We can also consider adding -debug switch to all cmdlets which will show what API calls are used in background and API responses - that should simplify troubleshooting.

    38. let's leverage Verbose and Debug information as appropriate

    39. Need to have "WhatIf" flag - Indicates that the cmdlet is run only to display the changes that would be made and actually no objects are modified (VMW definition)

    40. Need to have RunAsync flag - Indicates that the command returns immediately without waiting for the task to complete. In this mode, the output of the cmdlet is a Task object

        3. For some methods, this may require API changes, especially if we're going to have this be "Ergon centric"

16. Testability

    41. We need full unit test / automated test coverage, which should be tested nightly or with new builds.

    42. Build/test status should be surfaced in GitHub, so users know when code is solid

17. Cmdlets need to support pipelining and object references

    43. Meaning I should be able, for example, to "get" a VLAN and then create a VM with that network referenced in the same pipeline.

    44. Conversely, for example, I should be able to create a new network and then create a VM with that network referenced as an object

18. All cmdlets need to use approved verbs, with zero exceptions

    45. [https://msdn.microsoft.com/en-us/library/ms714428(v=vs.85).aspx](https://urldefense.proofpoint.com/v2/url?u=https-3A__msdn.microsoft.com_en-2Dus_library_ms714428-28v-3Dvs.85-29.aspx&d=DwMGaQ&c=s883GpUCOChKOHiocYtGcg&r=NGPRGGo37mQiSXgHKm5rCQ&m=KflV8elw1X6Wzdzc8iNEs3ce-dLR9kUlxesCSuGDVOI&s=HPpsI4HyH8GmFIypZUVHPdZA0xBjSWumCWPTT1tnNYQ&e=)

    46.  leverage Get-Verb for guidance, see [https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.core/functions/get-verb?view=powershell-5.1](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.core/functions/get-verb?view=powershell-5.1).

19. Need to think through "collision" strategy for other providers.

    47. For example, if we created "new-vm" that would colide/clobber with other vendors.

    48. I'm not a huge fan of what we’re doing today with things like new-ntnxvm, as it just doesn’t feel right, so there has to be a middle ground. Perhaps there is a graceful way in powershell 6 to mediate this.

20. Need to leverage SDK, so that client side code is easy to extend and follows a repeatable pattern

    49. V3 SDK design: https://docs.google.com/document/d/1Jx_SAKA7dldiVt2M5sVYAzui8FLofki3ztuVK1vixY4/edit?ts=5a5fe11f#heading=h.qfwgp46srnxf

21. Follow well accepted build and push standards

    50. [http://ramblingcookiemonster.github.io/Building-A-PowerShell-Module/](http://ramblingcookiemonster.github.io/Building-A-PowerShell-Module/) 

22. Need coverage for everything that has an API endpoint, within reason

    51. Primary target should be prism central

    52. as soon as any rest API Is out of tech preview we should have a powershell module for it

    53. That means both VM/entity CRUD as well as "cluster" level CRUD for administrative options

        4. Cmdlet mapping doc: [https://docs.google.com/spreadsheets/d/1LUnXF7CApiaqjKMSYinDPWr2ycEaA9WOu83WJ4vwCfo/edit#gid=0](https://docs.google.com/spreadsheets/d/1LUnXF7CApiaqjKMSYinDPWr2ycEaA9WOu83WJ4vwCfo/edit#gid=0) 

        5. Should include typical things like DNS, NTP, SNMP, SMTP

            1. This ideally should be PC down, but likely we'll have to deal with PE directly too

        6. Should also include things like role mapping / access control and local user management

        7. Should also include private key management, such that a user could GET a certificate from their PKI, and push it to Nutanix with our cmdlets

        8. Should be able to push upgrades via PoSh (for AOS, LCM, etc)

            2. NOTE: This may require API tweaks if our GUI is doing something sneaky

    54. We should also be able to get statistics, for users who want to "poll" their clusters for reporting purposes. 

        9. Northern Trust already does something similar, but in reality, they'd want a more similar type of reporting like the vCheck report for VMW: [http://www.virtu-al.net/vcheck-pluginsheaders/vcheck/](http://www.virtu-al.net/vcheck-pluginsheaders/vcheck/) 

        10. Our PoSh needs to be able to enable this type of workflow

    55. Cloud-init/sysprep scripts should be able to be passed through, for the cloud-init/sysprep workflow

        11. Calling this out, as historically this is tricky, given the are a big text file object

    56. Within reason means that some API endpoints would naturally be wrapped up into a "workflow", so rather than a direct cmdlet for every single API cal, the API endpoint would be called as a byproduct of “meta” cmdlets.

    57. Also we need to think through "mapping" of ACLI/NCLI/NuClei/etc cmds to PowerShell cmds. People are going to DEMAND full coverage. We may not be able to deliver that day 1, but note that any gaps WILL produce CFD's, guaranteed. We see that with our PoSh support today

    58. Naturally, these need to support anything the API supports across the hypervisors we support.

    59. NEED A generic REST API cmdlet

        12. add a generic REST API cmdlet for anything that hans't been turned into a cmdlet yet

        13. it would handle credentials and error codes from the API

        14. you would give it a URL and a JSON as input

        15. it would return the usual JSON as output

        16. that way, we could easily access anything available in the REST API with minimal effort

        17. ideally, it would handle multi page responses as well

        18. also, thought of the generic REST method cmdlet

        19. we could have a Get-PrismHelp command that would retrieve the same stuff the REST API Explorer shows

        20. it could be used to get available endpoints, methods and required forms

        21. then an Invoke-PrismRESTMethod (with -method, -json and -url) to use REST when a specific cmdlet isn't available yet

    60. It would be also nice to have integration with creation of support cases (afaik this will be/was added to PC). Ideally it would require to pipe failing cmdlet to Create-NutanixCase, which will open new case and attach at least error message, API request/resonse and version info.

    61.  It would be good to have possibility to run NCC health checks and generate log bundles (same what we have in PE now) and upload them to FTP (or attach to case).

23. Need to think through how API mapping works

    62. It would be nice to have this translate through an SDK, but I know our SDK strategy is currently evolving

24. Need to think through debuggability and logging

25. Need to think through upgrades

    63. Upgrades to PoSh code

    64. Upgrades to AOS code

    65. Handling "current level" PoSh with down level AOS - need to try hard to make sure this work, as this will be how enterprises deploy

26. Need to think how API traceability works

    66. Quick and dirty thought would be to make the SDK's have a submission header against the Rest API, which then we could track as a click stream

    67. This might require changes to the rest API

27. Need to think through how authentication will work 

    68. From a customer case: 

        22. "When connecting to PRISM (4.1.4) using PowerShell, we always have to specify the username and password. Even though we have AD Integration setup, we still need to specify the username and password. it would be nice if we could just SSO when connecting to Prism (like with VMware/PowerCLI, ...)"

        23. Currently customer uses as, workaround, a text file with login/password (encrypted format) and use that to feed to the powershell script used to connect to the Prism.

28. Need to deprecate support for the in-build cmdlet code generation

    69. (ideally) eventually scrub out all of those legacy references to clean up the gateway code.

    70. This also means modifying "the button" in Prism that points to the cmdlet download, likely to just be a reference to download from the PoSh gallery

29. Barriers to Entry and Exit

    71. Need to think through barriers in AND out of this module

    72. Possible to align with other module schema, to make existing code portable in and out?

    73. Need to map existing module cmdlets to make sure that general workflow gaps don't naturally occur

30. Documentation

    74. Readme: See guidance below, and separate section with outline

        24. MVP should be level three on the feed me read me maturity model or better

        25. [https://github.com/LappleApple/feedmereadmes/blob/master/README-maturity-model.md#level-three-basic-readme](https://github.com/LappleApple/feedmereadmes/blob/master/README-maturity-model.md#level-three-basic-readme)

        26. Level Three: Basic README

        27. Some detailed information about the project's functionality, usefulness and purpose.

        28. Basic installation, configuration, running details for users, tested and complete.

        29. Basic documentation for potential contributors.

        30. A vision statement or project roadmap for onboarding new contributors.

        31. A Contributing.md/.rst file with basic information.

        32. A line about the project's build status, but minimal: "under development" or "stable."

        33. A line about the average response time to issues and/or pull requests.

        34. At least one badge showing code coverage or other quality metrics.

        35. Text updated at monthly or quarterly intervals, so inaccuracies may exist.

    75. Documentation should be reviewed by documentation team, but should be in-line and self documenting wherever possible

    76. If possible, pull syntax/documentation from API framework. This may drive us to improve/update documentation within framework; HOWEVER, we should not depend on this, especially in the context of the get-help workflows

    77. Changelog:

        36. How do we maintain changelog/release notes outside of existing RN cadence for production product

        37. Likely should not be based on git commit log, as that will generate too much noise

        38. [http://keepachangelog.com/en/1.0.0/](http://keepachangelog.com/en/1.0.0/) 

    78. Contributing guidelines: 

        39. Need to get from Victor

    79. License: 

        40. MIT per victor

    80. Issues

        41. Need to provide template

        42. Segue into supportability/support model

        43. Likely need to look at portal.nutanix.com/GitHub integration

    81. Samples (see separate section) 

    82. TOI (see separate section 

31. TOI - Transfer of Information

    83. Need to change up the way we do TOI's for Open Source products

    84. My initial thought would be a similar TOI format to what we do internally, but instead, pre-record it and put it on YouTube, and just send out the link for people to watch OR do a "live session" like we do today, but instead record it and put it up on YouTube

32. Samples 

    85. Along the lines of the TOI, each TOI/module should be accompanied by functional samples. 

    86. We should have a samples directory right within the repo, that can be actively maintained by the community.

    87. We should work with PowerShell SMEs internally to pre-populate this, with existing scripts that are refactored to support the new modules. This has the added benefit of really proving out functionality.

33. Supportability and Support Model

    88. Will it be supported as AOS/PC? Or will it be community only support via forums (like CE)?

        44. Users with support contracts on the equipment being interacted with can file portal tickets like usual

        45. Alternatively, both paid users and community users are encouraged to submit github issues; however, github issues are best effort basis. For critical and time bound responses, please leverage portal.nutanix.com support models

        46. development mainly on Community, also contributed to by a our developers, and integrate latest stable Community versions in AOS with major releases.

    89. GitHub / Portal.nutanix.com integration?

    90. Public facing JIRA project with GitHub integration?

    91. Outward bound alias: [PowerShell@nutanix.com](mailto:PowerShell@nutanix.com) 

    92. Public slack channel: 

34. Readme

    93. [https://www.makeareadme.com/](https://www.makeareadme.com/) 

    94. Name and description

        47. Make it immediately obvious what your project does at a high level.

        48. Put a meaningful, short, plain-language description of what this project is trying to accomplish and why it matters. Describe the problem(s) this project solves. Describe how this software can improve the lives of its audience.

        49. Other things to include:

            3. Technology stack: Indicate the technological nature of the software, including primary programming language(s) and whether the software is intended as standalone or as a module in a framework or other ecosystem.

            4. Status: Alpha, Beta, 1.1, etc. It's OK to write a sentence, too. The goal is to let interested people know where this project is at. This is also a good place to link to the CHANGELOG.

            5. Links to production or demo instances

            6. Describe what sets this apart from related-projects. Linking to another doc or page is OK if this can't be expressed in a sentence or two.

    95. Badges

        50. On some READMEs, you may see small images that convey metadata, such as whether or not all the tests are passing for the project. You can use Shields to add some to your README. Many services also have instructions for adding a badge.

    96. Features

        51. Let people know what your project can do specifically. If there is an alternative to your project, this is a good place to list differentiating factors.

    97. Visuals

        52. Depending on what you are making, it can be a good idea to include screenshots or even a video (you'll frequently see GIFs rather than actual videos). Tools like ttygif can help, but check out Asciinema for a more sophisticated method.

    98. Requirements

        53. If your project only works in a certain context, it's important to be upfront about its requirements. Otherwise, someone may try to use your project, only to discover that it requires a certain version of a language or a particular operating system.

    99. Installation

        54. Within a particular ecosystem, there may be a comman way of installing things, such as using Yarn, NuGet, or Homebrew. However, consider the possibility that whoever is reading your README is a novice and would like more guidance. Listing specific steps helps remove ambiguity and gets people to using your project as quickly as possible.

    100. Usage

        55. Use examples liberally, and show the expected output if you can. It's helpful to have inline the smallest example of usage that you can demonstrate, while providng links to more sophisticated examples if they are too long to reasonably include in the README.

    101. Support

        56. Tell people where they can go to for help. It can be any combination of an issue tracker, a chat room, an email address, etc.

    102. Development

        57. For people who want to make changes to your project, it's helpful to have some documentation on how to get started. Perhaps there is a script that they should run or some environment variables that they need to set. Make these steps explicit. These instructions could also be useful to your future self.

        58. You can also document commands to lint the code or run tests. These steps help to ensure high code quality and reduce the likelihood that the changes inadvertently break something. Having instructions for running tests is especially helpful if it requires external setup, such as starting a Selenium server for testing in a browser.

    103. Roadmap

        59. If you have ideas for releases in the future, it is a good idea to list them in the README.

    104. Contributing back

        60. If you are open to contributions from others, let them know what your requirements are for accepting contributions.

    105. Authors and acknowledgment

        61. Show your appreciation to those who have contributed to the project, by listing them perhaps.

    106. License

        62. For open source projects, say how it is licensed.

    107. Project status

        63. If you have run out of energy or time for your project, put a note at the top of the README saying that development has slowed down or stopped completely. Someone may choose to fork your project or volunteer to step in as a maintainer or owner, allowing your project to keep going. You can also make an explicit request for maintainers.

    108. STANDARD README

        64. What do you want to name your module?

        65. What is the description of this module?

        66. Do have a banner image?

        67. Where is the banner image? Ex: 'img/banner.png'

        68. Do you want a TODO dropped where your badges should be?

        69. Do you want a TODO dropped where your long description should be?

        70. Do you need a prioritized security section?

        71. Do you need a background section?

        72. Do you need an API section?

        73. What is the GitHub handle of the main maintainer?

        74. Do you have a CONTRIBUTE.md file?

        75. Are PRs accepted?

        76. Is an MIT license OK?

        77. What is your license?

        78. Who is the License holder (probably your name)?

        79. Use the current year?

        80. What years would you like to specify?

    109. Open Source readme

        81. Dependencies

            7. Describe any dependencies that must be installed for this software to work. This includes programming languages, databases or other storage mechanisms, build tools, frameworks, and so forth. If specific versions of other software are required, or known not to work, call that out.

35. Zalando's README Template

    110. [https://github.com/zalando/zalando-howto-open-source/blob/master/READMEtemplate.md](https://github.com/zalando/zalando-howto-open-source/blob/master/READMEtemplate.md) 

    111. Clear documentation is critical to the success of your project. This checklist is meant to help you cover all your bases. Not every section/subsection will be relevant to your project; pick and choose what is. Inspired by READMEs of very successful projects like etcd.

    112. Please copy-paste this into a new document and save as you build your READMEs. For alternative formats, you might create a Structured README, which offers a thorough breakdown of optional README ingredients for you to consider. You might also take a look at this similar checklist; or check out art-of-readme.

    113. Project Name/Intro

        82. Describe very briefly but clearly what the project does.

        83. State if it is out-of-the-box user-friendly, so it's clear to the user.

        84. List its most useful/innovative/noteworthy features.

        85. State its goals/what problem(s) it solves.

        86. Note and briefly describe any key concepts (technical, philosophical, or both) important to the user's understanding.

        87. Link to any supplementary blog posts or project main pages.

        88. Note its development status.

        89. Include badges.

        90. If possible, include screenshots and demo videos.

    114. Core Technical Concepts/Inspiration

        91. Why does it exist?

        92. Frame your project for the potential user.

        93. Compare/contrast your project with other, similar projects so the user knows how it is different from those projects.

        94. Highlight the technical concepts that your project demonstrates or supports. Keep it very brief.

        95. Keep it useful.

    115. Getting Started/Requirements/Prerequisites/Dependencies

        96. Include any essential instructions for:

            8. Getting it

            9. Installing It

            10. Configuring It

            11. Running it

    116. More Specific Topics (+ sample sub-categories)

        97. Versioning: Services, APIs, Systems

        98. Common Error Messages/related details

        99. Tests

    117. Contributing

        100. Contributor Guidelines

        101. Code Style/Requirements

        102. Format for commit messages

        103. Thank you (name contributors)

    118. TODO

        104. Next steps

        105. Features planned

        106. Known bugs (shortlist)

    119. Contact

        107. Email address

        108. Google Group/mailing list (if applicable)

        109. IRC or Slack (if applicable)

    120. License

Beta Users

BKD - Brett, David, David

Marty @ Dell

JJ @ BBY

Comments to integrate from IVAN

Dear Nutanix Team, I've looked through the document and find it to be a very good start. I have a few comments and hope that you'll find them useful. I'll send them as separate messages as otherwise they look more like a blog post 

In Section 7 you may want to also consider the future structure of the module, i.e.:

    - Include everything into a single PSM1 file (one file to sign, however this may cause more merge conflicts going forward)

    - Keep all the cmdlets in separate ps1 files (in sub-folder) and have some code in PSM1 to dot-source them all on load (less likely to get git merge conflicts, more files to sign)

    - Keep all the cmdlets in separate ps1 files (in sub-folder) and combine them all into one huge PSM1 file at build time (less likely to get git merge conflicts, one file to sign, harder to match faulty lines of code based on error messages)

An ability to run cmdlets in asynchronously (section 9.f) is great. It would be really nice if there would also be a cmdlet (i.e. Wait-Task) that would allow waiting for one or all of the supplied tasks and Get-Task that would allow querying for additional details (i.e. Task Name, task details if there are any, task state, etc.) of the async tasks. That would allow making scripts that depend on long running async tasks be more responsive.

Are there any plans on the release cycle? i.e. release a new version of the module every time a new version of AOS/PS is out, or more frequently (i.e. once a month, etc.)?

As for Cmdlet name collisions (Section 13), generally there are two ways to avoid them:

    • Prefix all the nouns with something, i.e. NTNX and not bother about collisions

    • Pick common/familiar cmdlet names, and have users either rely on module-qualified names (https://www.sapien.com/blog/2015/10/23/using-module-qualified-cmdlet-names/) when there's a need to use several modules with identical cmdlet names or  use -Prefix parameter of the Import-Module cmdlet to avoid collisions.

There doesn't seem to be any best practice established on this, as there are many good examples for both approaches: 

    With Prefix: Cisco PowerTool Module, MS System Center, Azure

    Without Prefix: VMWare, Hyper-V

I personally like cmdlet names with prefix, since they require less typing and worrying less about collisions. Another argument for prefixing nouns is that when googling for New-NTNXVM you're more likely going to get Nutanix related results, as opposed to when searching for New-VM cmdlet.

### Post Sale Considerations & Serviceability over Feature/Product Life 

* * *


NEED TO UPDATE FROM CAMS TEMPLATE

These should be considered standard P0 items for any new feature, how the feature integrates with the rest of the Nutanix ecosystem - where applicable. 

* **_Guardrails:_**

    * If a target cluster is less than AOS 5.0 then alert that the cluster cannot be used with LCM on PC 

    * If a target cluster has an old LCM Framework (eg. LCM v1.0), do we need to ensure they are running the latest prior to any LCM on PC functions? 

* **_Logs_***: (what should be collected)*

    * LCM on PC should have unique logs separate from LCM on PE logs to differentiate between the two frameworks 

* **_PulseHD:_**

    * Collect items from LCM on PC results such as: Last Run Status (ok/fail), Cumulative Run Counts, Pass/Fail counts, What scheduling interval used, time to complete inventory and updates (LCM run duration) per cluster

* **_Panacea_**

    * LCM logs needs to be in a format that Panacea can consume 

* **_Upgrading and/or LCM integration:  _**

    * LCM in PC framework also needs the ability to upgrade itself 

    * Ensure that any future upgrades of LCM on PC keeps the current scheduling and other settings as per the user's wishes 

* **_Foundation: _**

    * LCM in PC to support upgrading CVM Foundation on PE 

* **_NCC: _**

    * LCM team to write NCC checks for LCM in PC (what health aspects of LCM need to be monitored according to LCM Engg) 

* **_Serviceability:_*** *

    * LCM in PC must be self-updatable 

    * Procedure for repairing/replacing corrupted or deleted LCM on PC files (re-install force option?) for SREs etc 

* **_Alerts:_*** *

    * LCM on PC is operational or not 

    * LCM on PC unable to reach a PE cluster (eg state change) after a usable set time

    * Monitor Prism Central storage usage, eg alert when 75% full etc if PC hosts repo files 

* **_QA Tests to be added : _**

* **_Failure Mode Effects and Analysis (FMEA)_**

    * If LCM in PC fails, what are the effects on conducting upgrades on PE ?  (Are the requirements that LCM in PC must be restored functional prior to PE upgrades?) 

* **_Field Enablement / TOI training : _**

    * * *

