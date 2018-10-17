function New-VmSnapshotListMetadataObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='The filter in FIQL syntax used for the results.')]
    [string]
    ${Filter},

    [Parameter(ParameterSetName='default', HelpMessage='The kind name')]
    [string]
    ${Kind},

    [Parameter(ParameterSetName='default', HelpMessage='The number of records to retrieve relative to the offset')]
    [int]
    ${Length},

    [Parameter(ParameterSetName='default', HelpMessage='Offset from the start of the entity list')]
    [int]
    ${Offset},

    [Parameter(ParameterSetName='default', HelpMessage='The attribute to perform sort on')]
    [string]
    ${SortAttribute},

    [Parameter(ParameterSetName='default', HelpMessage='The sort order in which results are returned')]
    [string]
    ${SortOrder})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmSnapshotListMetadataObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmSnapshotListMetadataObject
.ForwardHelpCategory Cmdlet

#>

}

