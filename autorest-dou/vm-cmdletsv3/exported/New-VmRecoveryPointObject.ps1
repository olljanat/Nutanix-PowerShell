function New-VmRecoveryPointObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The kind name')]
    [string]
    ${AvailabilityZoneReferenceKind},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The kind name')]
    [string]
    ${AvailabilityZoneReferenceKind1},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${AvailabilityZoneReferenceName},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${AvailabilityZoneReferenceName1},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${AvailabilityZoneReferenceUuid},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${AvailabilityZoneReferenceUuid1},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The kind name')]
    [string]
    ${ClusterReferenceKind},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The kind name')]
    [string]
    ${ClusterReferenceKind1},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceName},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceName1},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceUuid},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceUuid1},

    [Parameter(ParameterSetName='default', HelpMessage='The time when the the recovery point is created. This is in internetdate/time format (RFC 3339). For example, 1985-04-12T23:20:50.52Z,this represents 20 minutes and 50.52 seconds after the 23rd hour ofApril 12th, 1985 in UTC.')]
    [datetime]
    ${CreationTime},

    [Parameter(ParameterSetName='default', HelpMessage='The time when this recovery point expires and will be garbagecollected. This is in internet date/time format (RFC 3339). Forexample, 1985-04-12T23:20:50.52Z, this represents 20 minutes and50.52 seconds after the 23rd hour of April 12th, 1985 in UTC. If notset, then the recovery point never expires.')]
    [datetime]
    ${ExpirationTime},

    [Parameter(ParameterSetName='default', HelpMessage='Name of the recovery point.')]
    [string]
    ${Name},

    [Parameter(ParameterSetName='default', HelpMessage='Crash consistent or Application Consistent recovery point')]
    [string]
    ${RecoveryPointType},

    [Parameter(ParameterSetName='default', HelpMessage='Location agnostic UUID of the recovery point. If a recoverypoint is replicated to a different clusters, then all theinstances of same recovery point will share this UUID.')]
    [string]
    ${VmRecoveryPointResourcesVmRecoveryPointLocationAgnosticUuid},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The kind name')]
    [string]
    ${VmReferenceKind},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${VmReferenceName},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${VmReferenceUuid})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmRecoveryPointObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmRecoveryPointObject
.ForwardHelpCategory Cmdlet

#>

}

