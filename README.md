
# Nutanix Powershell



This repository contains a set of PowerShell cmdlets for developers and administrators to develop, deploy and manage Nutanix Enterprise Cloud Applications

[![GoDoc](https://godoc.org/github.com/tools/godep?status.svg)](https://developer.nutanix.com/reference/prism_central/v3/)



Nutanix Powershell cmdlets helps to manage Nutanix Enterprise Cloud Applications using Powershell 6 with Powershell Core.



This tools asumes that you already have a Nutanix Account created and its credentials.



## Requirements



- Powershell v6

- Powershell Core

- S.O. Windows, Linux or Mac

- Nutanix Account



## Install



After clone the Nutanix Powershell repository, run:



```console

Import-Module -Name .\Nutanix.psd1

```



## Verify Nutanix Module Installation



To verify the Nutanix Powershell module, run:



```console

> Get-Module -Name Nutanix

```



This will retrieve the Nutanix Module info



``` console

ModuleType Version Name ExportedCommands

---------- ------- ---- ----------------

Manifest 1.0 Nutanix {Get-Image, Get-ServiceVm, Get-Task, Get-TaskList...}

```



## How to get the availables cmdlets



After import the Nutanix we could get the avaibles cmdlets running the command:



```console

> Get-Command -Module Nutanix

```



This will retrieve a list with the availables cmdlets of the Module



``` console

CommandType Name Version Source

----------- ---- ------- ------

Function Get-Image 1.0 Nutanix

Function Get-ServiceVm 1.0 Nutanix

Function Get-Task 1.0 Nutanix

Function Get-TaskList 1.0 Nutanix

Function Invoke-Image 1.0 Nutanix

Function New-AccessControlPolicyListMetadataObject 1.0 Nutanix

Function New-AvailabilityZoneReferenceObject 1.0 Nutanix

Function New-ChecksumObject 1.0 Nutanix

Function New-ClusterReferenceObject 1.0 Nutanix

Function New-DiskObject 1.0 Nutanix

Function New-Image 1.0 Nutanix

Function New-ImageIntentInputObject 1.0 Nutanix

Function New-ImageListMetadataObject 1.0 Nutanix

Function New-ImageMetadataObject 1.0 Nutanix

Function New-ImageMigrateInputObject 1.0 Nutanix

Function New-ImageObject 1.0 Nutanix

Function New-ImageResourcesObject 1.0 Nutanix

Function New-ImageVersionResourcesObject 1.0 Nutanix

Function New-Migrate 1.0 Nutanix

Function New-NutanixCredential 1.0 Nutanix

Function New-Poll 1.0 Nutanix

Function New-ProjectReferenceObject 1.0 Nutanix

Function New-ServiceVm 1.0 Nutanix

Function New-TaskListMetadataObject 1.0 Nutanix

Function New-TaskPollInputObject 1.0 Nutanix

Function New-UserReferenceObject 1.0 Nutanix

Function New-VmIntentInputObject 1.0 Nutanix

Function New-VmListMetadataObject 1.0 Nutanix

Function New-VmMetadataObject 1.0 Nutanix

Function New-VmObject 1.0 Nutanix

Function New-VmRecoveryPointIntentInputObject 1.0 Nutanix

Function New-VmRecoveryPointListMetadataObject 1.0 Nutanix

Function New-VmRecoveryPointMetadataObject 1.0 Nutanix

Function New-VmResourcesObject 1.0 Nutanix

Function Remove-Image 1.0 Nutanix

Function Remove-ServiceVm 1.0 Nutanix

Function Set-Image 1.0 Nutanix

Function Set-NutanixCredential 1.0 Nutanix

```

  ## The Nutanix Credential Object
  Every cmdlets in the Nutanix Module needs Authentication before run, so, we count with the cmdlet:

```console
New-NutanixCredential
```

This cmdlet requires some specific params that we can see with the command **Get-Help**:

```console
Get-Help New-NutanixCredential

NAME
    New-NutanixCredential

SYNOPSIS


SYNTAX
    New-NutanixCredential [-Username <String>] [-Password <String>] [-ServerUri <String>] [<CommonParameters>]

    New-NutanixCredential [-Server <String>] [-Port <String>] [-Protocol <String>] [-Username <String>] [-Password <String>] [<CommonParameters>]


DESCRIPTION


RELATED LINKS

REMARKS
    To see the examples, type: "get-help New-NutanixCredential -examples".
    For more information, type: "get-help New-NutanixCredential -detailed".
    For technical information, type: "get-help New-NutanixCredential -full".
```
At this point we can set our credentials to an object, by example:

```console
$credentials = New-NutanixCredential -password "" -username "" -port 0000 -server "localhost"
```
And then, pass this object to every cmdlets:
``` console
Get-TaskList -SkipSSL -Credential $credentials
```

## Global credentials

To set out credentials globaly we can use the cmdlet:
``` console
Set-NutanixCredential
```
This cmdlet can set our credentials globaly to the environment variables, by example:

``` console
Set-NutanixCredential -Credential $credentials
```

And with this, we can execute every single cmdlet without set the -Credential flag

``` console
Get-Image -SkipSSL
```

## Get Cmdlets Help



At this points, every single cmdlet has it's own documentation/help section, to invoke this option, run:



``` console

Get-Help [CmdletName]

```



By example, at test this option with the **New-ServiceVm** cmdlets we got:



```console

PS C:\Users\\Documents\repositories\PowerShell> Get-Help New-ServiceVm



NAME

New-ServiceVm



SYNOPSIS




SYNTAX

New-ServiceVm [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]

[-ProxyUseDefaultCredentials] [-Username <String>] [-Password <SecureString>] [-SkipSSL] [-Credential <NutanixCredential>] [-Server <String>] [-Port <String>]

[-Protocol <String>] [-ApiVersion <String>] -Metadata <IVmMetadata> -Spec <IVm> [-Async] [-WhatIf] [-Confirm] [<CommonParameters>]



New-ServiceVm [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]

[-ProxyUseDefaultCredentials] [-Username <String>] [-Password <SecureString>] [-SkipSSL] [-Credential <NutanixCredential>] [-Server <String>] [-Port <String>]

[-Protocol <String>] -Body <IVmIntentInput> [-WhatIf] [-Confirm] [<CommonParameters>]



New-ServiceVm [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-DiskSizeMib <Int32>] [-NumSockets <Int32>] [-NumVcpusPerSocket

<Int32>] [-MemorySizeMib <Int32>] [-PowerState <String>] [-ClusterReferenceUuid <String>] [-Name <String>] [-Description <String>] [-Proxy <Uri>]

[-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-Username <String>] [-Password <SecureString>] [-SkipSSL] [-Credential <NutanixCredential>]

[-Server <String>] [-Port <String>] [-Protocol <String>] [-WhatIf] [-Confirm] [<CommonParameters>]




DESCRIPTION




RELATED LINKS



REMARKS

To see the examples, type: "get-help New-ServiceVm -examples".

For more information, type: "get-help New-ServiceVm -detailed".

For technical information, type: "get-help New-ServiceVm -full".

```



## Uninstalling



To remove the module from the Powershell env, run:



```console

Remove-Module Nutanix

```



At this point, no metadata stays on your env so we could install the Nutanix Module without issues



## Verify uninstall



To verify that we already uninstall the Nutanix module was successful, run:



``` console

Get-Module Nutanix

```



And we should see nothing in the powershell



## Next features



1. New cmdlets to work with:

- Vmware

- Security Rules

- Disk

- etc