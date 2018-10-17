function New-VmBootConfigObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Indicates the order of device types in which VM should try to boot from. If boot device order is not provided the system will decide appropriate boot device order.')]
    [string[]]
    ${BootDeviceOrderList},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${DiskAddressAdapterType},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [int]
    ${DiskAddressDeviceIndex},

    [Parameter(ParameterSetName='default', HelpMessage='MAC address of nic to boot from.')]
    [string]
    ${VmBootDeviceMacAddress})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmBootConfigObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmBootConfigObject
.ForwardHelpCategory Cmdlet

#>

}

