function Set-ServiceRecoveryPoint {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpec', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='An intentful representation of a vm_recovery_point')]
    [Sample.API.Models.IVmRecoveryPointIntentInput]
    ${Body},

    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpec', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpecExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpec', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpecExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpec', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpecExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpec', Mandatory=$true, HelpMessage='The UUID of the entity.')]
    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The UUID of the entity.')]
    [string]
    ${Uuid},

    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ApiVersion},

    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The vm_recovery_point kind metadata')]
    [Sample.API.Models.IVmRecoveryPointMetadata]
    ${Metadata},

    [Parameter(ParameterSetName='RecoveryPointUuidApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The input object that defines a vm recovery point.')]
    [Sample.API.Models.IVmRecoveryPoint]
    ${Spec})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'RecoveryPointUuidApiVersionMetadataSpec' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-ServiceRecoveryPoint_RecoveryPointUuidApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'RecoveryPointUuidApiVersionMetadataSpecExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-ServiceRecoveryPoint_RecoveryPointUuidApiVersionMetadataSpecExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-ServiceRecoveryPoint_RecoveryPointUuidApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Set-ServiceRecoveryPoint_RecoveryPointUuidApiVersionMetadataSpec
.ForwardHelpCategory Cmdlet

#>

}

