function New-ServiceSnapshot {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpec', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='An intentful representation of a vm_snapshot')]
    [Sample.API.Models.IVmSnapshotIntentInput]
    ${Body},

    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpec', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpecExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpec', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpecExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpec', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpecExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ApiVersion},

    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The vm_snapshot kind metadata')]
    [Sample.API.Models.IVmSnapshotMetadata]
    ${Metadata},

    [Parameter(ParameterSetName='SnapshotApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The input object that defines a VM snapshot')]
    [Sample.API.Models.IVmSnapshot]
    ${Spec})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'SnapshotApiVersionMetadataSpecExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-ServiceSnapshot_SnapshotApiVersionMetadataSpecExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SnapshotApiVersionMetadataSpec' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-ServiceSnapshot_SnapshotApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  default {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-ServiceSnapshot_SnapshotApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

}
}

process
{
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end
{
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
<#

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-ServiceSnapshot_SnapshotApiVersionMetadataSpec
.ForwardHelpCategory Cmdlet

#>

}

