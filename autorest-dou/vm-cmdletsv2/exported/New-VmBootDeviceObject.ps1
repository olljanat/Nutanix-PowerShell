function New-VmBootDeviceObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${DiskAddressAdapterType},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [int]
    ${DiskAddressDeviceIndex},

    [Parameter(ParameterSetName='default', HelpMessage='MAC address of nic to boot from.')]
    [string]
    ${MacAddress})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmBootDeviceObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmBootDeviceObject
.ForwardHelpCategory Cmdlet

#>

}

