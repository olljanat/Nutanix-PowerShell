function New-VmObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${AvailabilityZoneReferenceName},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${AvailabilityZoneReferenceUuid},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceName},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceUuid},

    [Parameter(ParameterSetName='default', HelpMessage='A description for vm.')]
    [string]
    ${Description},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='vm Name.')]
    [string]
    ${Name},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='VM Resources Definition.')]
    [Nutanix.Powershell.Models.IVmResources]
    ${Resources})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmObject
.ForwardHelpCategory Cmdlet

#>

}

