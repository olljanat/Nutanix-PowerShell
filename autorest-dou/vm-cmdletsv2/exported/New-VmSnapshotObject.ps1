function New-VmSnapshotObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='The time when this snapshot expires and will be garbage collected.If not set, then the snapshot never expires.')]
    [int]
    ${ExpirationTimeMsecs},

    [Parameter(ParameterSetName='default', HelpMessage='Name of the snapshot')]
    [string]
    ${Name},

    [Parameter(ParameterSetName='default', HelpMessage='This describes a list replication targets where this snapshot existsor needs to be replicated to. This is to support the replication andretrieve of the snapshot.')]
    [Sample.API.Models.IVmSnapshotReplicationTargetListItemType[]]
    ${ReplicationTargetList},

    [Parameter(ParameterSetName='default', HelpMessage='Crash consistent or Application Consistent snapshot')]
    [string]
    ${SnapshotType},

    [Parameter(ParameterSetName='default', HelpMessage='UUID of the base entity for which snapshot need to be taken')]
    [string]
    ${VmSnapshotResourcesEntityUuid})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmSnapshotObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmSnapshotObject
.ForwardHelpCategory Cmdlet

#>

}

