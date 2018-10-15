function Invoke-VmService {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='All api calls that return a list will have this metadata block as input
')]
    [Sample.API.Models.IVmListMetadata]
    ${GetEntitiesRequest},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The username for authentication')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The username for authentication')]
    [string]
    ${username},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The password for authentication')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The password for authentication')]
    [string]
    ${password},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Skip the ssl validation')]
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

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The filter in FIQL syntax used for the results.')]
    [string]
    ${Filter},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The number of records to retrieve relative to the offset')]
    [int]
    ${Length},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Offset from the start of the entity list')]
    [int]
    ${Offset},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The attribute to perform sort on')]
    [string]
    ${SortAttribute},

    [Parameter(ParameterSetName='FilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The sort order in which results are returned')]
    [string]
    ${SortOrder})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'FilterKindLengthOffsetSortAttributeSortOrder' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Invoke-VmService_FilterKindLengthOffsetSortAttributeSortOrder', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'FilterKindLengthOffsetSortAttributeSortOrderExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Invoke-VmService_FilterKindLengthOffsetSortAttributeSortOrderExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Invoke-VmService_FilterKindLengthOffsetSortAttributeSortOrder', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Invoke-VmService_FilterKindLengthOffsetSortAttributeSortOrder
.ForwardHelpCategory Cmdlet

#>

}

