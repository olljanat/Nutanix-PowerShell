function Get-ServiceSnapshost {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrder', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='All api calls that return a list will have this metadata block as input
')]
    [Sample.API.Models.IVmSnapshotListMetadata]
    ${GetEntitiesRequest},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The filter in FIQL syntax used for the results.')]
    [string]
    ${Filter},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The kind name')]
    [string]
    ${Kind},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The number of records to retrieve relative to the offset')]
    [int]
    ${Length},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Offset from the start of the entity list')]
    [int]
    ${Offset},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The attribute to perform sort on')]
    [string]
    ${SortAttribute},

    [Parameter(ParameterSetName='SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The sort order in which results are returned')]
    [string]
    ${SortOrder})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-ServiceSnapshost_SnapshostsFilterKindLengthOffsetSortAttributeSortOrderExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SnapshostsFilterKindLengthOffsetSortAttributeSortOrder' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-ServiceSnapshost_SnapshostsFilterKindLengthOffsetSortAttributeSortOrder', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-ServiceSnapshost_SnapshostsFilterKindLengthOffsetSortAttributeSortOrder', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Get-ServiceSnapshost_SnapshostsFilterKindLengthOffsetSortAttributeSortOrder
.ForwardHelpCategory Cmdlet

#>

}

