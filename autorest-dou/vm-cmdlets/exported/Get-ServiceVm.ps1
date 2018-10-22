function Get-ServiceVm {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='VmUuid', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='VmUuid', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='VmUuid', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='VmUuid', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='VmUuid', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='VmUuid', HelpMessage='The username for authentication')]
    [string]
    ${username},

    [Parameter(ParameterSetName='VmUuid', HelpMessage='The password for authentication')]
    [string]
    ${password},

    [Parameter(ParameterSetName='VmUuid', HelpMessage='Skip the ssl validation')]
    [switch]
    ${SkipSSL},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Skip the ssl validation')]
    [ValidateNotNull()]
    [pscredential]
    ${Credential},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The username for authentication')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The username for authentication')]
    [string]
    ${Server},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The username for authentication')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The username for authentication')]
    [string]
    ${Port},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The username for authentication')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The username for authentication')]
    [string]
    ${Protocol},

    [Parameter(ParameterSetName='VmUuid', Mandatory=$true, HelpMessage='The UUID of the entity.')]
    [string]
    ${Uuid})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-ServiceVm_VmUuid', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Get-ServiceVm_VmUuid
.ForwardHelpCategory Cmdlet

#>

}

