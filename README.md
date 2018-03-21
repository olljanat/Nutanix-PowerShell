# Nutanix PowerShell
What, Why, and Goals
--------------------
Nutanix is committed to making PowerShell a first-class feature. In service of that goal, Nutanix is planning to deprecate the existing PowerShell cmdlets, in favor of this fully open source project.

Nutanix cmdlets are being replaced with a "from the ground up" rewrite, leveraging our latest API's and Microsoft's PowerShell 6.x code train. 

This new release will fundamentally enhance our functionality, including:
* PowerShell 6.0 Support for Windows, Linux, and OSX
* Module support, for easy integration with editors like Visual Studio Code
* PowerShell Gallery support, for ease of deployment
* Simplified, easy to use Cmdlets with traditional virtualization sysadmin semantics 
* Verbose Get-Help with detailed examples on each cmdlet
* Production supported, with additional Open Source community collaboration on GitHub and Slack
* Nutanix v3 API support - This means Calm, Micro Seg, and all of the other goodies. 
* Note: legacy API’s will only be leveraged for methods not yet available in v3 API 

Nutanix is taking an inclusive approach to developing this new feature and welcomes customer feedback. Please see our development project on GitHub, comment on requirements and/or design, and feel free to join us on Slack. Instructions on commenting, contributing, and joining our community Slack channel are all located within our GitHub Readme.

For a slack invite, please contact PowerShell@nutanix.com from your business address, and we'll add you.

Roadmap
--------------------
If you're reading this, you're in on the ground floor. Really, the parking garage. We've just started to put in the foundation for this project, and we're "soft launching" by opening up so people can check out our development progress.

In the short term, we'll be adding our full requirements list as we build our our documentation, and start baking in a proper readme, etc.

Quick Install
-------------

Just try out the Docker image?

    sudo docker run -it kasprosian/ntnx-powershell bash

Then inside the container:

    cd /Powershell
    sh test/sanity_test.sh

Install Dependencies
--------------------

Make sure nuget is installed (check via `which nuget`).

    make deps

Install from source
-------------------

    make

Install from package
--------------------

TODO: coming soon, a way to install from powershell gallery.
