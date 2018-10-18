function New-VmSnapshotIntentInputObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ApiVersion},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The vm_snapshot kind metadata')]
    [Sample.API.Models.IVmSnapshotMetadata]
    ${Metadata},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The input object that defines a VM snapshot')]
    [Sample.API.Models.IVmSnapshot]
    ${Spec})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmSnapshotIntentInputObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmSnapshotIntentInputObject
.ForwardHelpCategory Cmdlet

#>

}

