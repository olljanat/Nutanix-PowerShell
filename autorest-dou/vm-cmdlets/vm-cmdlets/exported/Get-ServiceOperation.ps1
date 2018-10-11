function Get-ServiceOperation {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttribute', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='All api calls that return a list will have this metadata block as input
')]
    [Sample.API.Models.IAccessControlPolicyListMetadata]
    ${GetEntitiesRequest},

    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttribute', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttributeExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttribute', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttributeExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttribute', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttributeExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttribute', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttributeExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttribute', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttributeExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttributeExpanded', HelpMessage='The filter in FIQL syntax used for the results.')]
    [string]
    ${Filter},

    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttributeExpanded', HelpMessage='The kind name')]
    [string]
    ${Kind},

    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttributeExpanded', HelpMessage='The number of records to retrieve relative to the offset')]
    [int]
    ${Length},

    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttributeExpanded', HelpMessage='Offset from the start of the entity list')]
    [int]
    ${Offset},

    [Parameter(ParameterSetName='OperationFilterKindLengthOffsetSortAttributeExpanded', HelpMessage='The attribute to perform sort on')]
    [string]
    ${SortAttribute})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'OperationFilterKindLengthOffsetSortAttributeExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-ServiceOperation_OperationFilterKindLengthOffsetSortAttributeExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'OperationFilterKindLengthOffsetSortAttribute' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-ServiceOperation_OperationFilterKindLengthOffsetSortAttribute', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-ServiceOperation_OperationFilterKindLengthOffsetSortAttribute', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Get-ServiceOperation_OperationFilterKindLengthOffsetSortAttribute
.ForwardHelpCategory Cmdlet

#>

}

