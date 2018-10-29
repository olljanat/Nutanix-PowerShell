function New-ImageObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='A description for image.')]
    [string]
    ${Description},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='image Name.')]
    [string]
    ${Name},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='Describes the image spec resources object.')]
    [Nutanix.Powershell.Models.IImageResources]
    ${Resources})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-ImageObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-ImageObject
.ForwardHelpCategory Cmdlet

#>

}

