function Invoke-ClusterService {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuid', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuidExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuid', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuidExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuid', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuidExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuid', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuidExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuid', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuidExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuid', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='Entity placement spec')]
    [Sample.API.Models.IPlacementSpec]
    ${Spec},

    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuidExpanded', Mandatory=$true, HelpMessage='The kind name')]
    [string]
    ${ClusterReferenceKind},

    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuidExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceName},

    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuidExpanded', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceUuid},

    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuidExpanded', Mandatory=$true, HelpMessage='List of entity specs')]
    [Sample.API.Models.IEntitySpec[]]
    ${EntitySpecList},

    [Parameter(ParameterSetName='EntitySpecListProbableClusterReferenceTenantUuidExpanded', HelpMessage='UUID of the tenant')]
    [string]
    ${TenantUuid})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'EntitySpecListProbableClusterReferenceTenantUuid' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Invoke-ClusterService_EntitySpecListProbableClusterReferenceTenantUuid', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'EntitySpecListProbableClusterReferenceTenantUuidExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Invoke-ClusterService_EntitySpecListProbableClusterReferenceTenantUuidExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Invoke-ClusterService_EntitySpecListProbableClusterReferenceTenantUuid', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Invoke-ClusterService_EntitySpecListProbableClusterReferenceTenantUuid
.ForwardHelpCategory Cmdlet

#>

}

