function New-DiskAddressObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${AdapterType},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [int]
    ${DeviceIndex})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-DiskAddressObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-DiskAddressObject
.ForwardHelpCategory Cmdlet

#>

}

