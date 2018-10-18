function Set-ServiceSnapshot {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpec', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='An intentful representation of a vm_snapshot')]
    [Sample.API.Models.IVmSnapshotIntentInput]
    ${Body},

    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpec', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpecExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpec', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpecExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpec', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpecExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpec', Mandatory=$true, HelpMessage='The UUID of the entity.')]
    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The UUID of the entity.')]
    [string]
    ${Uuid},

    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ApiVersion},

    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The vm_snapshot kind metadata')]
    [Sample.API.Models.IVmSnapshotMetadata]
    ${Metadata},

    [Parameter(ParameterSetName='SnapshotUuidApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The input object that defines a VM snapshot')]
    [Sample.API.Models.IVmSnapshot]
    ${Spec})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'SnapshotUuidApiVersionMetadataSpecExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-ServiceSnapshot_SnapshotUuidApiVersionMetadataSpecExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SnapshotUuidApiVersionMetadataSpec' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-ServiceSnapshot_SnapshotUuidApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-ServiceSnapshot_SnapshotUuidApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Set-ServiceSnapshot_SnapshotUuidApiVersionMetadataSpec
.ForwardHelpCategory Cmdlet

#>

}

